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
            // InspectionsForm - Modern Professional Theme
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 250);
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
            //
            // lblPipeline
            //
            this.lblPipeline.AutoSize = true;
            this.lblPipeline.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblPipeline.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblPipeline.Location = new Point(25, 20);
            this.lblPipeline.Name = "lblPipeline";
            this.lblPipeline.Size = new Size(107, 20);
            this.lblPipeline.TabIndex = 0;
            this.lblPipeline.Text = "Трубопровод:";
            //
            // cbPipelines
            //
            this.cbPipelines.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbPipelines.Font = new Font("Segoe UI", 10F);
            this.cbPipelines.FormattingEnabled = true;
            this.cbPipelines.Location = new Point(140, 17);
            this.cbPipelines.Name = "cbPipelines";
            this.cbPipelines.Size = new Size(500, 25);
            this.cbPipelines.TabIndex = 1;
            this.cbPipelines.FlatStyle = FlatStyle.Popup;
            this.cbPipelines.SelectionChangeCommitted += new EventHandler(this.cbPipelines_SelectionChangeCommitted);
            //
            // dgv
            //
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = Color.White;
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(41, 128, 185)
            };
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = Color.FromArgb(236, 240, 241);
            this.dgv.Location = new Point(25, 55);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new Size(934, 260);
            this.dgv.TabIndex = 2;
            this.dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9F),
                SelectionBackColor = Color.FromArgb(189, 195, 199),
                SelectionForeColor = Color.Black
            };
            //
            // lblDate
            //
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new Font("Segoe UI", 9F);
            this.lblDate.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblDate.Location = new Point(25, 330);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(42, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Дата:";
            //
            // dtpDate
            //
            this.dtpDate.Font = new Font("Segoe UI", 9F);
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(80, 327);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(150, 23);
            this.dtpDate.TabIndex = 4;
            //
            // lblTool
            //
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new Font("Segoe UI", 9F);
            this.lblTool.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblTool.Location = new Point(250, 330);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new Size(62, 15);
            this.lblTool.TabIndex = 5;
            this.lblTool.Text = "Прибор:";
            //
            // txtTool
            //
            this.txtTool.Font = new Font("Segoe UI", 9F);
            this.txtTool.Location = new Point(320, 327);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new Size(200, 23);
            this.txtTool.TabIndex = 6;
            this.txtTool.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblSpeed
            //
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new Font("Segoe UI", 9F);
            this.lblSpeed.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblSpeed.Location = new Point(25, 365);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new Size(104, 15);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "Скорость (м/с):";
            //
            // txtSpeed
            //
            this.txtSpeed.Font = new Font("Segoe UI", 9F);
            this.txtSpeed.Location = new Point(130, 362);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new Size(100, 23);
            this.txtSpeed.TabIndex = 8;
            this.txtSpeed.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblCoverage
            //
            this.lblCoverage.AutoSize = true;
            this.lblCoverage.Font = new Font("Segoe UI", 9F);
            this.lblCoverage.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblCoverage.Location = new Point(250, 365);
            this.lblCoverage.Name = "lblCoverage";
            this.lblCoverage.Size = new Size(75, 15);
            this.lblCoverage.TabIndex = 9;
            this.lblCoverage.Text = "Охват (%):";
            //
            // txtCoverage
            //
            this.txtCoverage.Font = new Font("Segoe UI", 9F);
            this.txtCoverage.Location = new Point(330, 362);
            this.txtCoverage.Name = "txtCoverage";
            this.txtCoverage.Size = new Size(100, 23);
            this.txtCoverage.TabIndex = 10;
            this.txtCoverage.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblStatus.Location = new Point(450, 365);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(54, 15);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Статус:";
            //
            // cbStatus
            //
            this.cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new Font("Segoe UI", 9F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] { "Completed", "Pending", "In Progress" });
            this.cbStatus.Location = new Point(510, 362);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new Size(150, 23);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.FlatStyle = FlatStyle.Popup;
            this.cbStatus.SelectedIndex = 0;
            //
            // btnAdd
            //
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            this.btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 136, 76);
            this.btnAdd.Location = new Point(25, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(180, 38);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "➕ Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Font = new Font("Segoe UI", 10F);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 56, 40);
            this.btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            this.btnDelete.Location = new Point(220, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(180, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "🗑️ Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font = new Font("Segoe UI", 10F);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.BackColor = Color.FromArgb(155, 89, 182);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 68, 173);
            this.btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(118, 49, 153);
            this.btnRefresh.Location = new Point(420, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(180, 38);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "🔄 Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            //
            // btnOpenDefects
            //
            this.btnOpenDefects.FlatStyle = FlatStyle.Flat;
            this.btnOpenDefects.Font = new Font("Segoe UI", 10F);
            this.btnOpenDefects.ForeColor = Color.White;
            this.btnOpenDefects.BackColor = Color.FromArgb(52, 152, 219);
            this.btnOpenDefects.FlatAppearance.BorderSize = 0;
            this.btnOpenDefects.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnOpenDefects.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 140);
            this.btnOpenDefects.Location = new Point(620, 415);
            this.btnOpenDefects.Name = "btnOpenDefects";
            this.btnOpenDefects.Size = new Size(180, 38);
            this.btnOpenDefects.TabIndex = 16;
            this.btnOpenDefects.Text = "📈 Дефекты →";
            this.btnOpenDefects.UseVisualStyleBackColor = false;
            this.btnOpenDefects.Click += new EventHandler(this.btnOpenDefects_Click);
            //
            // btnClose
            //
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 10F);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.BackColor = Color.FromArgb(149, 165, 166);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 140, 141);
            this.btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 106, 106);
            this.btnClose.Location = new Point(820, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(140, 38);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "❌ Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            //
            // InspectionsForm
            //
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}