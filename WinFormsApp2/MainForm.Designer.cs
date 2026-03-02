using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Label lblPipelineCount;
        private Label lblInspectionCount;
        private Label lblCriticalCount;
        private DataGridView dgvCritical;
        private Button btnPipelines;
        private Button btnInspections;
        private Button btnDefects;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new Label();
            this.lblPipelineCount = new Label();
            this.lblInspectionCount = new Label();
            this.lblCriticalCount = new Label();
            this.dgvCritical = new DataGridView();
            this.btnPipelines = new Button();
            this.btnInspections = new Button();
            this.btnDefects = new Button();
            this.btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCritical)).BeginInit();
            this.SuspendLayout();

            // MainForm - Modern Professional Theme
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.ClientSize = new Size(984, 591);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Главное меню - Система ВТД";
            this.Load += new System.EventHandler(this.MainForm_Load);
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblWelcome.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblWelcome.Location = new Point(30, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(200, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать";
            //
            // lblPipelineCount
            //
            this.lblPipelineCount.AutoSize = true;
            this.lblPipelineCount.BackColor = Color.White;
            this.lblPipelineCount.Font = new Font("Segoe UI", 11F);
            this.lblPipelineCount.ForeColor = Color.FromArgb(52, 152, 219);
            this.lblPipelineCount.Location = new Point(30, 75);
            this.lblPipelineCount.Name = "lblPipelineCount";
            this.lblPipelineCount.Padding = new Padding(15, 10, 15, 10);
            this.lblPipelineCount.Size = new Size(180, 40);
            this.lblPipelineCount.TabIndex = 1;
            this.lblPipelineCount.Text = "📊 Трубопроводов: 0";
            this.lblPipelineCount.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblInspectionCount
            //
            this.lblInspectionCount.AutoSize = true;
            this.lblInspectionCount.BackColor = Color.White;
            this.lblInspectionCount.Font = new Font("Segoe UI", 11F);
            this.lblInspectionCount.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblInspectionCount.Location = new Point(30, 125);
            this.lblInspectionCount.Name = "lblInspectionCount";
            this.lblInspectionCount.Padding = new Padding(15, 10, 15, 10);
            this.lblInspectionCount.Size = new Size(180, 40);
            this.lblInspectionCount.TabIndex = 2;
            this.lblInspectionCount.Text = "🔍 Инспекций: 0";
            this.lblInspectionCount.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblCriticalCount
            //
            this.lblCriticalCount.AutoSize = true;
            this.lblCriticalCount.BackColor = Color.FromArgb(255, 240, 240);
            this.lblCriticalCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblCriticalCount.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblCriticalCount.Location = new Point(30, 175);
            this.lblCriticalCount.Name = "lblCriticalCount";
            this.lblCriticalCount.Padding = new Padding(15, 10, 15, 10);
            this.lblCriticalCount.Size = new Size(240, 40);
            this.lblCriticalCount.TabIndex = 3;
            this.lblCriticalCount.Text = "⚠️ Критических дефектов: 0";
            this.lblCriticalCount.BorderStyle = BorderStyle.FixedSingle;
            //
            // dgvCritical
            //
            this.dgvCritical.AllowUserToAddRows = false;
            this.dgvCritical.AllowUserToDeleteRows = false;
            this.dgvCritical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCritical.BackgroundColor = Color.White;
            this.dgvCritical.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCritical.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(41, 128, 185)
            };
            this.dgvCritical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCritical.EnableHeadersVisualStyles = false;
            this.dgvCritical.GridColor = Color.FromArgb(236, 240, 241);
            this.dgvCritical.Location = new Point(30, 230);
            this.dgvCritical.Name = "dgvCritical";
            this.dgvCritical.ReadOnly = true;
            this.dgvCritical.RowHeadersVisible = false;
            this.dgvCritical.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCritical.Size = new Size(924, 280);
            this.dgvCritical.TabIndex = 4;
            this.dgvCritical.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9F),
                SelectionBackColor = Color.FromArgb(189, 195, 199),
                SelectionForeColor = Color.Black
            };
            //
            // btnPipelines
            //
            this.btnPipelines.FlatStyle = FlatStyle.Flat;
            this.btnPipelines.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnPipelines.ForeColor = Color.White;
            this.btnPipelines.BackColor = Color.FromArgb(52, 152, 219);
            this.btnPipelines.FlatAppearance.BorderSize = 0;
            this.btnPipelines.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnPipelines.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 140);
            this.btnPipelines.Location = new Point(30, 530);
            this.btnPipelines.Name = "btnPipelines";
            this.btnPipelines.Size = new Size(220, 45);
            this.btnPipelines.TabIndex = 5;
            this.btnPipelines.Text = "🗂️ Трубопроводы";
            this.btnPipelines.UseVisualStyleBackColor = false;
            this.btnPipelines.Click += new System.EventHandler(this.btnPipelines_Click);
            //
            // btnInspections
            //
            this.btnInspections.FlatStyle = FlatStyle.Flat;
            this.btnInspections.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnInspections.ForeColor = Color.White;
            this.btnInspections.BackColor = Color.FromArgb(46, 204, 113);
            this.btnInspections.FlatAppearance.BorderSize = 0;
            this.btnInspections.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            this.btnInspections.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 136, 76);
            this.btnInspections.Location = new Point(270, 530);
            this.btnInspections.Name = "btnInspections";
            this.btnInspections.Size = new Size(220, 45);
            this.btnInspections.TabIndex = 6;
            this.btnInspections.Text = "🔍 Инспекции";
            this.btnInspections.UseVisualStyleBackColor = false;
            this.btnInspections.Click += new System.EventHandler(this.btnInspections_Click);
            //
            // btnDefects
            //
            this.btnDefects.FlatStyle = FlatStyle.Flat;
            this.btnDefects.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnDefects.ForeColor = Color.White;
            this.btnDefects.BackColor = Color.FromArgb(155, 89, 182);
            this.btnDefects.FlatAppearance.BorderSize = 0;
            this.btnDefects.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 68, 173);
            this.btnDefects.FlatAppearance.MouseDownBackColor = Color.FromArgb(118, 49, 153);
            this.btnDefects.Location = new Point(510, 530);
            this.btnDefects.Name = "btnDefects";
            this.btnDefects.Size = new Size(220, 45);
            this.btnDefects.TabIndex = 7;
            this.btnDefects.Text = "📈 Анализ дефектов";
            this.btnDefects.UseVisualStyleBackColor = false;
            this.btnDefects.Click += new System.EventHandler(this.btnDefects_Click);
            //
            // btnExit
            //
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.Font = new Font("Segoe UI", 11F);
            this.btnExit.ForeColor = Color.White;
            this.btnExit.BackColor = Color.FromArgb(149, 165, 166);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 140, 141);
            this.btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 106, 106);
            this.btnExit.Location = new Point(750, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(204, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "🚪 Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefects);
            this.Controls.Add(this.btnInspections);
            this.Controls.Add(this.btnPipelines);
            this.Controls.Add(this.dgvCritical);
            this.Controls.Add(this.lblCriticalCount);
            this.Controls.Add(this.lblInspectionCount);
            this.Controls.Add(this.lblPipelineCount);
            this.Controls.Add(this.lblWelcome);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCritical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
