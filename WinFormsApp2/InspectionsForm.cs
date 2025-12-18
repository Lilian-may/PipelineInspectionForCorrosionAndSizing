using System;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp2
{
    public partial class InspectionsForm : Form
    {
        private readonly UserContext _ctx;
        private readonly int? _pipelineId;

        public InspectionsForm(UserContext ctx, int? pipelineId = null)
        {
            _ctx = ctx;
            _pipelineId = pipelineId;
            InitializeComponent();
        }

        private void InspectionsForm_Load(object sender, EventArgs e)
        {
            LoadPipelinesCombo();

            txtSpeed.KeyPress += DecimalTextBox_KeyPress;
            txtCoverage.KeyPress += DecimalTextBox_KeyPress;

            if (_pipelineId.HasValue && cbPipelines.Items.Count > 0)
                cbPipelines.SelectedValue = _pipelineId.Value;

            if (cbPipelines.Items.Count > 0)
                LoadInspections();
        }

        private void LoadPipelinesCombo()
        {
            var dt = Db.QueryTable("SELECT id, name FROM pipelines ORDER BY name");
            cbPipelines.DisplayMember = "name";
            cbPipelines.ValueMember = "id";
            cbPipelines.DataSource = dt;
        }

        private int SelectedPipelineId()
        {
            if (cbPipelines.SelectedValue == null)
                throw new ArgumentException("Выберите трубопровод.");

            return Convert.ToInt32(cbPipelines.SelectedValue);
        }

        private void LoadInspections()
        {
            try
            {
                int pid = SelectedPipelineId();

                var dt = Db.QueryTable(@"
                    SELECT i.id AS ID,
                           i.inspection_date AS Дата,
                           t.name AS Прибор,
                           i.speed_mps AS Скорость_м_с,
                           i.coverage_percent AS Охват_проц,
                           i.status AS Статус
                    FROM inspections i
                    JOIN tool_types t ON t.id = i.tool_type_id
                    WHERE i.pipeline_id=@pid
                    ORDER BY i.inspection_date DESC;",
                    new MySqlParameter("@pid", pid));

                dgv.DataSource = dt;
                if (dgv.Columns.Contains("ID"))
                    dgv.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? SelectedInspectionId()
        {
            if (dgv.CurrentRow == null) return null;
            var val = dgv.CurrentRow.Cells["ID"]?.Value;
            if (val == null || val == DBNull.Value) return null;
            return Convert.ToInt32(val);
        }

        private void cbPipelines_SelectionChangeCommitted(object sender, EventArgs e) => LoadInspections();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadInspections();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = SelectedPipelineId();

                var date = dtpDate.Value;
                var toolName = Validators.RequiredTextOnly(txtTool.Text, "Тип прибора", 60);
                var speed = Validators.ParseDecimal(txtSpeed.Text, "Скорость (м/с)", 0.01m, 20m);
                var cov = Validators.ParseDecimal(txtCoverage.Text, "Охват (%)", 0m, 100m);
                var status = cbStatus.SelectedItem?.ToString() ?? "Completed";

                int toolId;
                var result = Db.Scalar("SELECT id FROM tool_types WHERE name=@n",
                    new MySqlParameter("@n", toolName));

                if (result == null || result == DBNull.Value)
                {
                    try
                    {
                        Db.Exec("INSERT INTO tool_types(name) VALUES(@n)",
                            new MySqlParameter("@n", toolName));

                        var newId = Db.Scalar("SELECT LAST_INSERT_ID()");
                        toolId = Convert.ToInt32(newId);
                    }
                    catch (Exception ex)
                    {
                        result = Db.Scalar("SELECT id FROM tool_types WHERE name=@n",
                            new MySqlParameter("@n", toolName));

                        if (result != null && result != DBNull.Value)
                        {
                            toolId = Convert.ToInt32(result);
                        }
                        else
                        {
                            throw new Exception($"Не удалось создать тип прибора: {ex.Message}");
                        }
                    }
                }
                else
                {
                    toolId = Convert.ToInt32(result);
                }

                Db.Exec(@"
            INSERT INTO inspections(pipeline_id, inspection_date, tool_type_id, speed_mps, coverage_percent, status)
            VALUES(@pid,@d,@t,@s,@c,@st)",
                    new MySqlParameter("@pid", pid),
                    new MySqlParameter("@d", date),
                    new MySqlParameter("@t", toolId),
                    new MySqlParameter("@s", speed),
                    new MySqlParameter("@c", cov),
                    new MySqlParameter("@st", status)
                );

                LoadInspections();

                txtTool.Clear();
                txtSpeed.Clear();
                txtCoverage.Clear();

                MessageBox.Show("Инспекция добавлена.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении инспекции:\n\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = SelectedInspectionId();
            if (id == null)
            {
                MessageBox.Show("Выберите инспекцию.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ctx.Role != UserRole.Admin)
            {
                MessageBox.Show("Удаление инспекции доступно только администратору.", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Удалить инспекцию? Будут удалены связанные дефекты.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res != DialogResult.Yes) return;

            Db.Exec("DELETE FROM inspections WHERE id=@id", new MySqlParameter("@id", id.Value));
            LoadInspections();
        }

        private void btnOpenDefects_Click(object sender, EventArgs e)
        {
            var id = SelectedInspectionId();
            if (id == null)
            {
                MessageBox.Show("Выберите инспекцию.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var f = new DefectAnalysisForm(_ctx, id.Value);
            f.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void DecimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox.Text.Contains(".") || textBox.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }
    }
}
