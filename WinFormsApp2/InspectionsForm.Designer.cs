using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp2
{
    partial class InspectionsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblPipeline;
        private ComboBox cbPipelines;
        private DataGridView dgv;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblTool;
        private TextBox txtTool;
        private Label lblSpeed;
        private TextBox txtSpeed;
        private Label lblCoverage;
        private TextBox txtCoverage;
        private Label lblStatus;
        private ComboBox cbStatus;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnOpenDefects;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPipeline = new Label();
            this.cbPipelines = new ComboBox();
            this.dgv = new DataGridView();
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.lblTool = new Label();
            this.txtTool = new TextBox();
            this.lblSpeed = new Label();
            this.txtSpeed = new TextBox();
            this.lblCoverage = new Label();
            this.txtCoverage = new TextBox();
            this.lblStatus = new Label();
            this.cbStatus = new ComboBox();
            this.btnAdd = new Button();
            this.btnDelete = new Button();
            this.btnRefresh = new Button();
            this.btnOpenDefects = new Button();
            this.btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPipeline
            // 
            this.lblPipeline.AutoSize = true;
            this.lblPipeline.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.lblPipeline.Location = new Point(20, 20);
            this.lblPipeline.Name = "lblPipeline";
            this.lblPipeline.Size = new Size(107, 19);
            this.lblPipeline.TabIndex = 0;
            this.lblPipeline.Text = "Трубопровод:";
            // 
            // cbPipelines
            // 
            this.cbPipelines.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbPipelines.Font = new Font("Times New Roman", 12F);
            this.cbPipelines.FormattingEnabled = true;
            this.cbPipelines.Location = new Point(140, 17);
            this.cbPipelines.Name = "cbPipelines";
            this.cbPipelines.Size = new Size(500, 27);
            this.cbPipelines.TabIndex = 1;
            this.cbPipelines.SelectionChangeCommitted += new EventHandler(this.cbPipelines_SelectionChangeCommitted);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new Point(20, 60);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new Size(940, 250);
            this.dgv.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new Font("Times New Roman", 11F);
            this.lblDate.Location = new Point(20, 330);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(42, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Дата:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new Font("Times New Roman", 11F);
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(80, 327);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(150, 24);
            this.dtpDate.TabIndex = 4;
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new Font("Times New Roman", 11F);
            this.lblTool.Location = new Point(250, 330);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new Size(62, 17);
            this.lblTool.TabIndex = 5;
            this.lblTool.Text = "Прибор:";
            // 
            // txtTool
            // 
            this.txtTool.Font = new Font("Times New Roman", 11F);
            this.txtTool.Location = new Point(320, 327);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new Size(200, 24);
            this.txtTool.TabIndex = 6;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new Font("Times New Roman", 11F);
            this.lblSpeed.Location = new Point(20, 370);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new Size(104, 17);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "Скорость (м/с):";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Font = new Font("Times New Roman", 11F);
            this.txtSpeed.Location = new Point(130, 367);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new Size(100, 24);
            this.txtSpeed.TabIndex = 8;
            // 
            // lblCoverage
            // 
            this.lblCoverage.AutoSize = true;
            this.lblCoverage.Font = new Font("Times New Roman", 11F);
            this.lblCoverage.Location = new Point(250, 370);
            this.lblCoverage.Name = "lblCoverage";
            this.lblCoverage.Size = new Size(75, 17);
            this.lblCoverage.TabIndex = 9;
            this.lblCoverage.Text = "Охват (%):";
            // 
            // txtCoverage
            // 
            this.txtCoverage.Font = new Font("Times New Roman", 11F);
            this.txtCoverage.Location = new Point(330, 367);
            this.txtCoverage.Name = "txtCoverage";
            this.txtCoverage.Size = new Size(100, 24);
            this.txtCoverage.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Times New Roman", 11F);
            this.lblStatus.Location = new Point(450, 370);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(54, 17);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Статус:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new Font("Times New Roman", 11F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] { "Completed", "Pending", "In Progress" });
            this.cbStatus.Location = new Point(510, 367);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new Size(150, 25);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.SelectedIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            this.btnAdd.Location = new Point(20, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(180, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new Font("Times New Roman", 11F);
            this.btnDelete.Location = new Point(220, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(180, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new Font("Times New Roman", 11F);
            this.btnRefresh.Location = new Point(420, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(180, 35);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenDefects
            // 
            this.btnOpenDefects.Font = new Font("Times New Roman", 11F);
            this.btnOpenDefects.Location = new Point(620, 420);
            this.btnOpenDefects.Name = "btnOpenDefects";
            this.btnOpenDefects.Size = new Size(180, 35);
            this.btnOpenDefects.TabIndex = 16;
            this.btnOpenDefects.Text = "Дефекты →";
            this.btnOpenDefects.UseVisualStyleBackColor = true;
            this.btnOpenDefects.Click += new EventHandler(this.btnOpenDefects_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new Font("Times New Roman", 11F);
            this.btnClose.Location = new Point(820, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(140, 35);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            // 
            // InspectionsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(984, 481);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenDefects);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCoverage);
            this.Controls.Add(this.lblCoverage);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtTool);
            this.Controls.Add(this.lblTool);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbPipelines);
            this.Controls.Add(this.lblPipeline);
            this.Name = "InspectionsForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Инспекции";
            this.Load += new EventHandler(this.InspectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
