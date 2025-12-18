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
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            this.lblWelcome.Location = new Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(200, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать";
            // 
            // lblPipelineCount
            // 
            this.lblPipelineCount.AutoSize = true;
            this.lblPipelineCount.Font = new Font("Times New Roman", 12F);
            this.lblPipelineCount.Location = new Point(20, 60);
            this.lblPipelineCount.Name = "lblPipelineCount";
            this.lblPipelineCount.Size = new Size(150, 19);
            this.lblPipelineCount.TabIndex = 1;
            this.lblPipelineCount.Text = "Трубопроводов: 0";
            // 
            // lblInspectionCount
            // 
            this.lblInspectionCount.AutoSize = true;
            this.lblInspectionCount.Font = new Font("Times New Roman", 12F);
            this.lblInspectionCount.Location = new Point(20, 90);
            this.lblInspectionCount.Name = "lblInspectionCount";
            this.lblInspectionCount.Size = new Size(120, 19);
            this.lblInspectionCount.TabIndex = 2;
            this.lblInspectionCount.Text = "Инспекций: 0";
            // 
            // lblCriticalCount
            // 
            this.lblCriticalCount.AutoSize = true;
            this.lblCriticalCount.Font = new Font("Times New Roman", 12F);
            this.lblCriticalCount.ForeColor = Color.Red;
            this.lblCriticalCount.Location = new Point(20, 120);
            this.lblCriticalCount.Name = "lblCriticalCount";
            this.lblCriticalCount.Size = new Size(220, 19);
            this.lblCriticalCount.TabIndex = 3;
            this.lblCriticalCount.Text = "Критических дефектов: 0";
            // 
            // dgvCritical
            // 
            this.dgvCritical.AllowUserToAddRows = false;
            this.dgvCritical.AllowUserToDeleteRows = false;
            this.dgvCritical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCritical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCritical.Location = new Point(20, 160);
            this.dgvCritical.Name = "dgvCritical";
            this.dgvCritical.ReadOnly = true;
            this.dgvCritical.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCritical.Size = new Size(940, 350);
            this.dgvCritical.TabIndex = 4;
            // 
            // btnPipelines
            // 
            this.btnPipelines.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.btnPipelines.Location = new Point(20, 530);
            this.btnPipelines.Name = "btnPipelines";
            this.btnPipelines.Size = new Size(220, 40);
            this.btnPipelines.TabIndex = 5;
            this.btnPipelines.Text = "Трубопроводы";
            this.btnPipelines.UseVisualStyleBackColor = true;
            this.btnPipelines.Click += new System.EventHandler(this.btnPipelines_Click);
            // 
            // btnInspections
            // 
            this.btnInspections.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.btnInspections.Location = new Point(260, 530);
            this.btnInspections.Name = "btnInspections";
            this.btnInspections.Size = new Size(220, 40);
            this.btnInspections.TabIndex = 6;
            this.btnInspections.Text = "Инспекции";
            this.btnInspections.UseVisualStyleBackColor = true;
            this.btnInspections.Click += new System.EventHandler(this.btnInspections_Click);
            // 
            // btnDefects
            // 
            this.btnDefects.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.btnDefects.Location = new Point(500, 530);
            this.btnDefects.Name = "btnDefects";
            this.btnDefects.Size = new Size(220, 40);
            this.btnDefects.TabIndex = 7;
            this.btnDefects.Text = "Анализ дефектов";
            this.btnDefects.UseVisualStyleBackColor = true;
            this.btnDefects.Click += new System.EventHandler(this.btnDefects_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new Font("Times New Roman", 12F);
            this.btnExit.Location = new Point(740, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(220, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(984, 591);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefects);
            this.Controls.Add(this.btnInspections);
            this.Controls.Add(this.btnPipelines);
            this.Controls.Add(this.dgvCritical);
            this.Controls.Add(this.lblCriticalCount);
            this.Controls.Add(this.lblInspectionCount);
            this.Controls.Add(this.lblPipelineCount);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Главное меню - Система ВТД";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCritical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
