using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private readonly UserContext _ctx;

        public MainForm(UserContext ctx)
        {
            _ctx = ctx;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Добро пожаловать, {_ctx.Login} ({_ctx.Role})";
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            var pCount = Db.Scalar("SELECT COUNT(*) FROM pipelines");
            var iCount = Db.Scalar("SELECT COUNT(*) FROM inspections");
            var cCount = Db.Scalar("SELECT COUNT(*) FROM defects WHERE severity='Critical'");

            lblPipelineCount.Text = $"Трубопроводов: {pCount}";
            lblInspectionCount.Text = $"Инспекций: {iCount}";
            lblCriticalCount.Text = $"Критических дефектов: {cCount}";

            var dt = Db.QueryTable(@"
                SELECT p.name AS Трубопровод,
                       i.inspection_date AS Дата,
                       d.kilometer AS Км,
                       d.depth_percent AS Глубина_проц,
                       d.length_mm AS Длина_мм,
                       d.width_mm AS Ширина_мм,
                       dt.name AS Тип,
                       d.severity AS Опасность,
                       d.risk_score AS Риск
                FROM defects d
                JOIN inspections i ON i.id = d.inspection_id
                JOIN pipelines p ON p.id = i.pipeline_id
                JOIN defect_types dt ON dt.id = d.defect_type_id
                WHERE d.severity='Critical'
                ORDER BY d.risk_score DESC
                LIMIT 50;
            ");

            dgvCritical.DataSource = dt;
        }

        private void btnPipelines_Click(object sender, EventArgs e)
        {
            using var f = new PipelinesForm(_ctx);
            f.ShowDialog();
            LoadDashboard();
        }

        private void btnInspections_Click(object sender, EventArgs e)
        {
            using var f = new InspectionsForm(_ctx);
            f.ShowDialog();
            LoadDashboard();
        }

        private void btnDefects_Click(object sender, EventArgs e)
        {
            using var f = new DefectAnalysisForm(_ctx);
            f.ShowDialog();
            LoadDashboard();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
