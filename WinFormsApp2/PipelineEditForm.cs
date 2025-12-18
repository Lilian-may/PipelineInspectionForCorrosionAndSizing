using System;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp2
{
    public partial class PipelineEditForm : Form
    {
        private readonly UserContext _ctx;
        private readonly int? _pipelineId;

        public PipelineEditForm(UserContext ctx, int? pipelineId)
        {
            _ctx = ctx;
            _pipelineId = pipelineId;
            InitializeComponent();
        }

        private void PipelineEditForm_Load(object sender, EventArgs e)
        {
            LoadMaterials();

            txtDiameter.KeyPress += NumericTextBox_KeyPress;
            txtLength.KeyPress += DecimalTextBox_KeyPress;
            txtPressure.KeyPress += DecimalTextBox_KeyPress;

            if (_pipelineId.HasValue)
            {
                this.Text = "Редактирование трубопровода";
                LoadPipeline();
            }
            else
            {
                this.Text = "Добавление трубопровода";
            }
        }

        private void LoadMaterials()
        {
            var dt = Db.QueryTable("SELECT id, name FROM materials ORDER BY name");
            cbMaterial.DisplayMember = "name";
            cbMaterial.ValueMember = "id";
            cbMaterial.DataSource = dt;
        }

        private void LoadPipeline()
        {
            if (!_pipelineId.HasValue) return;

            var dt = Db.QueryTable(
                "SELECT name, diameter_mm, length_km, material_id, pressure_mpa FROM pipelines WHERE id=@id",
                new MySqlParameter("@id", _pipelineId.Value)
            );

            if (dt.Rows.Count == 0) return;

            var row = dt.Rows[0];
            txtName.Text = row["name"]?.ToString() ?? "";
            txtDiameter.Text = row["diameter_mm"]?.ToString() ?? "";
            txtLength.Text = row["length_km"]?.ToString() ?? "";

            if (row["material_id"] != null && row["material_id"] != DBNull.Value)
            {
                cbMaterial.SelectedValue = Convert.ToInt32(row["material_id"]);
            }

            txtPressure.Text = row["pressure_mpa"]?.ToString() ?? "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var name = Validators.Required(txtName.Text, "Наименование", 120);
                var diameter = Validators.ParseDecimal(txtDiameter.Text, "Диаметр (мм)", 100, 2000);
                var length = Validators.ParseDecimal(txtLength.Text, "Длина (км)", 0.1m, 10000);
                var pressure = Validators.ParseDecimal(txtPressure.Text, "Давление (МПа)", 0.1m, 20);

                if (cbMaterial.SelectedValue == null)
                    throw new ArgumentException("Выберите материал.");

                int materialId = Convert.ToInt32(cbMaterial.SelectedValue);

                if (_pipelineId.HasValue)
                {
                    Db.Exec(@"
                        UPDATE pipelines
                        SET name=@n, diameter_mm=@d, length_km=@l, material_id=@m, pressure_mpa=@p
                        WHERE id=@id",
                        new MySqlParameter("@n", name),
                        new MySqlParameter("@d", diameter),
                        new MySqlParameter("@l", length),
                        new MySqlParameter("@m", materialId),
                        new MySqlParameter("@p", pressure),
                        new MySqlParameter("@id", _pipelineId.Value)
                    );
                }
                else
                {
                    Db.Exec(@"
                        INSERT INTO pipelines(name, diameter_mm, length_km, material_id, pressure_mpa)
                        VALUES(@n,@d,@l,@m,@p)",
                        new MySqlParameter("@n", name),
                        new MySqlParameter("@d", diameter),
                        new MySqlParameter("@l", length),
                        new MySqlParameter("@m", materialId),
                        new MySqlParameter("@p", pressure)
                    );
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
