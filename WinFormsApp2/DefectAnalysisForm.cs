using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp2
{
    public partial class DefectAnalysisForm : Form
    {
        private readonly UserContext _ctx;
        private int? _inspectionId;

        public DefectAnalysisForm(UserContext ctx, int? inspectionId = null)
        {
            _ctx = ctx;
            _inspectionId = inspectionId;
            InitializeComponent();
        }

        private void DefectAnalysisForm_Load(object sender, EventArgs e)
        {
            LoadInspectionsCombo();

            txtKm.KeyPress += DecimalTextBox_KeyPress;
            txtDepth.KeyPress += DecimalTextBox_KeyPress;
            txtLen.KeyPress += DecimalTextBox_KeyPress;
            txtWid.KeyPress += DecimalTextBox_KeyPress;

            if (_inspectionId.HasValue && cbInspections.Items.Count > 0)
                cbInspections.SelectedValue = _inspectionId.Value;

            cbSeverityFilter.SelectedIndex = 0;

            if (cbInspections.Items.Count > 0)
                LoadDefects();
        }

        private void LoadInspectionsCombo()
        {
            var dt = Db.QueryTable(@"
                SELECT i.id,
                       CONCAT(p.name, ' | ', DATE_FORMAT(i.inspection_date, '%Y-%m-%d'), ' | ', t.name) AS title
                FROM inspections i
                JOIN pipelines p ON p.id = i.pipeline_id
                JOIN tool_types t ON t.id = i.tool_type_id
                ORDER BY i.inspection_date DESC;
            ");

            cbInspections.DisplayMember = "title";
            cbInspections.ValueMember = "id";
            cbInspections.DataSource = dt;
        }

        private int SelectedInspectionId()
        {
            if (cbInspections.SelectedValue == null)
                throw new ArgumentException("Выберите инспекцию.");

            return Convert.ToInt32(cbInspections.SelectedValue);
        }

        private void LoadDefects()
        {
            try
            {
                int iid = SelectedInspectionId();
                string sev = cbSeverityFilter.SelectedItem?.ToString() ?? "Все";

                string sql = @"
                    SELECT d.id AS ID,
                           d.kilometer AS Км,
                           d.depth_percent AS Глубина_проц,
                           d.length_mm AS Длина_мм,
                           d.width_mm AS Ширина_мм,
                           dt.name AS Тип,
                           d.severity AS Опасность,
                           d.risk_score AS Риск
                    FROM defects d
                    JOIN defect_types dt ON dt.id = d.defect_type_id
                    WHERE d.inspection_id=@iid ";

                if (sev != "Все")
                    sql += " AND d.severity=@sev ";

                sql += " ORDER BY d.risk_score DESC, d.kilometer ASC;";

                DataTable dt = (sev == "Все")
                    ? Db.QueryTable(sql, new MySqlParameter("@iid", iid))
                    : Db.QueryTable(sql, new MySqlParameter("@iid", iid),
                                         new MySqlParameter("@sev", sev));

                dgv.DataSource = dt;
                if (dgv.Columns.Contains("ID"))
                    dgv.Columns["ID"].Visible = false;

                var crit = Convert.ToInt32(Db.Scalar(
                    "SELECT COUNT(*) FROM defects WHERE inspection_id=@iid AND severity='Critical'",
                    new MySqlParameter("@iid", iid)));

                lblCriticalCount.Text = $"Критических: {crit}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? SelectedDefectId()
        {
            if (dgv.CurrentRow == null) return null;
            var val = dgv.CurrentRow.Cells["ID"]?.Value;
            if (val == null || val == DBNull.Value) return null;
            return Convert.ToInt32(val);
        }

        private void cbInspections_SelectionChangeCommitted(object sender, EventArgs e) => LoadDefects();
        private void cbSeverityFilter_SelectionChangeCommitted(object sender, EventArgs e) => LoadDefects();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int iid = SelectedInspectionId();

                var km = Validators.ParseDecimal(txtKm.Text, "Километраж (км)", 0, 100000);
                var depth = Validators.ParseDecimal(txtDepth.Text, "Глубина (%)", 0, 100);
                var len = Validators.ParseDecimal(txtLen.Text, "Длина (мм)", 0.01m, 100000);
                var wid = Validators.ParseDecimal(txtWid.Text, "Ширина (мм)", 0.01m, 100000);
                var typeName = Validators.RequiredTextOnly(txtType.Text, "Тип дефекта", 60);

                var (sev, score) = RiskScoring.Evaluate(depth, len, wid);

                int typeId;
                var result = Db.Scalar("SELECT id FROM defect_types WHERE name=@n",
                    new MySqlParameter("@n", typeName));

                if (result == null || result == DBNull.Value)
                {
                    Db.Exec("INSERT INTO defect_types(name) VALUES(@n)",
                        new MySqlParameter("@n", typeName));

                    var newId = Db.Scalar("SELECT LAST_INSERT_ID()");
                    typeId = Convert.ToInt32(newId);
                }
                else
                {
                    typeId = Convert.ToInt32(result);
                }

                Db.Exec(@"
                    INSERT INTO defects(inspection_id, kilometer, depth_percent, length_mm, width_mm, defect_type_id, severity, risk_score)
                    VALUES(@iid,@km,@dp,@l,@w,@t,@s,@r)",
                    new MySqlParameter("@iid", iid),
                    new MySqlParameter("@km", km),
                    new MySqlParameter("@dp", depth),
                    new MySqlParameter("@l", len),
                    new MySqlParameter("@w", wid),
                    new MySqlParameter("@t", typeId),
                    new MySqlParameter("@s", sev),
                    new MySqlParameter("@r", score)
                );

                LoadDefects();

                txtKm.Clear();
                txtDepth.Clear();
                txtLen.Clear();
                txtWid.Clear();
                txtType.Clear();

                MessageBox.Show("Дефект добавлен.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении дефекта:\n\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecalc_Click(object sender, EventArgs e)
        {
            try
            {
                int iid = SelectedInspectionId();

                var dt = Db.QueryTable(@"
                    SELECT id, depth_percent, length_mm, width_mm
                    FROM defects
                    WHERE inspection_id=@iid",
                    new MySqlParameter("@iid", iid));

                foreach (DataRow r in dt.Rows)
                {
                    int id = Convert.ToInt32(r["id"]);
                    decimal depth = Convert.ToDecimal(r["depth_percent"]);
                    decimal len = Convert.ToDecimal(r["length_mm"]);
                    decimal wid = Convert.ToDecimal(r["width_mm"]);

                    var (sev, score) = RiskScoring.Evaluate(depth, len, wid);

                    Db.Exec("UPDATE defects SET severity=@s, risk_score=@r WHERE id=@id",
                        new MySqlParameter("@s", sev),
                        new MySqlParameter("@r", score),
                        new MySqlParameter("@id", id));
                }

                LoadDefects();
                MessageBox.Show("Перерасчёт выполнен.", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = SelectedDefectId();
            if (id == null)
            {
                MessageBox.Show("Выберите дефект.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ctx.Role != UserRole.Admin)
            {
                MessageBox.Show("Удаление дефекта доступно только администратору.", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Удалить дефект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes) return;

            Db.Exec("DELETE FROM defects WHERE id=@id", new MySqlParameter("@id", id.Value));
            LoadDefects();
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
