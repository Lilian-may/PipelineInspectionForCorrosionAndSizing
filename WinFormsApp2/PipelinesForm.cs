using System;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp2
{
    public partial class PipelinesForm : Form
    {
        private readonly UserContext _ctx;

        public PipelinesForm(UserContext ctx)
        {
            _ctx = ctx;
            InitializeComponent();
        }

        private void PipelinesForm_Load(object sender, EventArgs e)
        {
            lblRole.Text = $"Роль: {_ctx.Role}";
            btnAdd.Enabled = _ctx.Role == UserRole.Admin;
            btnEdit.Enabled = _ctx.Role == UserRole.Admin;
            btnDelete.Enabled = _ctx.Role == UserRole.Admin;
            LoadPipelines();
        }

        private void LoadPipelines()
        {
            var like = "%" + (txtSearch.Text ?? "").Trim() + "%";

            var dt = Db.QueryTable(@"
                SELECT p.id AS ID,
                       p.name AS Наименование,
                       p.diameter_mm AS Диаметр_мм,
                       p.length_km AS Длина_км,
                       m.name AS Материал,
                       p.pressure_mpa AS Давление_МПа,
                       p.created_at AS Создан
                FROM pipelines p
                JOIN materials m ON m.id = p.material_id
                WHERE p.name LIKE @q
                ORDER BY p.id DESC;",
                new MySqlParameter("@q", like));

            dgv.DataSource = dt;
            if (dgv.Columns.Contains("ID"))
                dgv.Columns["ID"].Visible = false;
        }

        private int? SelectedId()
        {
            if (dgv.CurrentRow == null) return null;
            if (dgv.CurrentRow.Cells["ID"]?.Value == null) return null;
            return Convert.ToInt32(dgv.CurrentRow.Cells["ID"].Value);
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadPipelines();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var f = new PipelineEditForm(_ctx, null);
            if (f.ShowDialog() == DialogResult.OK) LoadPipelines();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = SelectedId();
            if (id == null) return;

            using var f = new PipelineEditForm(_ctx, id.Value);
            if (f.ShowDialog() == DialogResult.OK) LoadPipelines();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = SelectedId();
            if (id == null) return;

            if (_ctx.Role != UserRole.Admin)
            {
                MessageBox.Show("Удаление доступно только администратору.", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show(
                "Удалить трубопровод? Будут удалены связанные инспекции и дефекты.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res != DialogResult.Yes) return;

            Db.Exec("DELETE FROM pipelines WHERE id=@id", new MySqlParameter("@id", id.Value));
            LoadPipelines();
        }

        private void btnOpenInspections_Click(object sender, EventArgs e)
        {
            var id = SelectedId();
            if (id == null) return;

            using var f = new InspectionsForm(_ctx, id.Value);
            f.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
