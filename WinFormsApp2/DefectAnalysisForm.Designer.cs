using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class DefectAnalysisForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblInspection;
        private ComboBox cbInspections;
        private Label lblFilter;
        private ComboBox cbSeverityFilter;
        private Label lblCriticalCount;
        private DataGridView dgv;
        private Label lblKm;
        private TextBox txtKm;
        private Label lblDepth;
        private TextBox txtDepth;
        private Label lblLen;
        private TextBox txtLen;
        private Label lblWid;
        private TextBox txtWid;
        private Label lblType;
        private TextBox txtType;
        private Button btnAdd;
        private Button btnRecalc;
        private Button btnDelete;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInspection = new Label();
            this.cbInspections = new ComboBox();
            this.lblFilter = new Label();
            this.cbSeverityFilter = new ComboBox();
            this.lblCriticalCount = new Label();
            this.dgv = new DataGridView();
            this.lblKm = new Label();
            this.txtKm = new TextBox();
            this.lblDepth = new Label();
            this.txtDepth = new TextBox();
            this.lblLen = new Label();
            this.txtLen = new TextBox();
            this.lblWid = new Label();
            this.txtWid = new TextBox();
            this.lblType = new Label();
            this.txtType = new TextBox();
            this.btnAdd = new Button();
            this.btnRecalc = new Button();
            this.btnDelete = new Button();
            this.btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInspection
            // 
            this.lblInspection.AutoSize = true;
            this.lblInspection.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblInspection.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblInspection.Location = new Point(25, 20);
            this.lblInspection.Name = "lblInspection";
            this.lblInspection.Size = new Size(88, 20);
            this.lblInspection.TabIndex = 0;
            this.lblInspection.Text = "Инспекция:";
            // 
            // cbInspections
            // 
            this.cbInspections.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbInspections.Font = new Font("Segoe UI", 10F);
            this.cbInspections.FormattingEnabled = true;
            this.cbInspections.Location = new Point(125, 17);
            this.cbInspections.Name = "cbInspections";
            this.cbInspections.Size = new Size(580, 25);
            this.cbInspections.TabIndex = 1;
            this.cbInspections.FlatStyle = FlatStyle.Popup;
            this.cbInspections.SelectionChangeCommitted += new EventHandler(this.cbInspections_SelectionChangeCommitted);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFilter.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFilter.Location = new Point(730, 20);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new Size(62, 19);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Фильтр:";
            // 
            // cbSeverityFilter
            // 
            this.cbSeverityFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSeverityFilter.Font = new Font("Segoe UI", 10F);
            this.cbSeverityFilter.FormattingEnabled = true;
            this.cbSeverityFilter.Items.AddRange(new object[] { "Все", "Low", "Medium", "High", "Critical" });
            this.cbSeverityFilter.Location = new Point(800, 17);
            this.cbSeverityFilter.Name = "cbSeverityFilter";
            this.cbSeverityFilter.Size = new Size(154, 25);
            this.cbSeverityFilter.TabIndex = 3;
            this.cbSeverityFilter.FlatStyle = FlatStyle.Popup;
            this.cbSeverityFilter.SelectionChangeCommitted += new EventHandler(this.cbSeverityFilter_SelectionChangeCommitted);
            // 
            // lblCriticalCount
            // 
            this.lblCriticalCount.AutoSize = true;
            this.lblCriticalCount.BackColor = Color.FromArgb(255, 243, 243);
            this.lblCriticalCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblCriticalCount.ForeColor = Color.FromArgb(231, 76, 60);
            this.lblCriticalCount.Location = new Point(25, 55);
            this.lblCriticalCount.Name = "lblCriticalCount";
            this.lblCriticalCount.Padding = new Padding(12, 8, 12, 8);
            this.lblCriticalCount.Size = new Size(140, 35);
            this.lblCriticalCount.TabIndex = 4;
            this.lblCriticalCount.Text = "⚠️ Критических: 0";
            this.lblCriticalCount.BorderStyle = BorderStyle.FixedSingle;
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
            this.dgv.Location = new Point(25, 100);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new Size(934, 260);
            this.dgv.TabIndex = 5;
            this.dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9F),
                SelectionBackColor = Color.FromArgb(189, 195, 199),
                SelectionForeColor = Color.Black
            };
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new Font("Segoe UI", 9F);
            this.lblKm.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblKm.Location = new Point(25, 375);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new Size(53, 15);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "Км (км):";
            // 
            // txtKm
            // 
            this.txtKm.Font = new Font("Segoe UI", 9F);
            this.txtKm.Location = new Point(85, 372);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new Size(85, 23);
            this.txtKm.TabIndex = 7;
            this.txtKm.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new Font("Segoe UI", 9F);
            this.lblDepth.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblDepth.Location = new Point(185, 375);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new Size(82, 15);
            this.lblDepth.TabIndex = 8;
            this.lblDepth.Text = "Глубина (%):";
            // 
            // txtDepth
            // 
            this.txtDepth.Font = new Font("Segoe UI", 9F);
            this.txtDepth.Location = new Point(270, 372);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new Size(75, 23);
            this.txtDepth.TabIndex = 9;
            this.txtDepth.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblLen
            // 
            this.lblLen.AutoSize = true;
            this.lblLen.Font = new Font("Segoe UI", 9F);
            this.lblLen.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblLen.Location = new Point(360, 375);
            this.lblLen.Name = "lblLen";
            this.lblLen.Size = new Size(80, 15);
            this.lblLen.TabIndex = 10;
            this.lblLen.Text = "Длина (мм):";
            // 
            // txtLen
            // 
            this.txtLen.Font = new Font("Segoe UI", 9F);
            this.txtLen.Location = new Point(445, 372);
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new Size(75, 23);
            this.txtLen.TabIndex = 11;
            this.txtLen.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblWid
            // 
            this.lblWid.AutoSize = true;
            this.lblWid.Font = new Font("Segoe UI", 9F);
            this.lblWid.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblWid.Location = new Point(535, 375);
            this.lblWid.Name = "lblWid";
            this.lblWid.Size = new Size(86, 15);
            this.lblWid.TabIndex = 12;
            this.lblWid.Text = "Ширина (мм):";
            // 
            // txtWid
            // 
            this.txtWid.Font = new Font("Segoe UI", 9F);
            this.txtWid.Location = new Point(625, 372);
            this.txtWid.Name = "txtWid";
            this.txtWid.Size = new Size(75, 23);
            this.txtWid.TabIndex = 13;
            this.txtWid.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new Font("Segoe UI", 9F);
            this.lblType.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblType.Location = new Point(715, 375);
            this.lblType.Name = "lblType";
            this.lblType.Size = new Size(33, 15);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Тип:";
            // 
            // txtType
            // 
            this.txtType.Font = new Font("Segoe UI", 9F);
            this.txtType.Location = new Point(755, 372);
            this.txtType.Name = "txtType";
            this.txtType.Size = new Size(204, 23);
            this.txtType.TabIndex = 15;
            this.txtType.BorderStyle = BorderStyle.FixedSingle;
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
            this.btnAdd.Location = new Point(25, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(210, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "➕ Добавить дефект";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnRecalc
            // 
            this.btnRecalc.FlatStyle = FlatStyle.Flat;
            this.btnRecalc.Font = new Font("Segoe UI", 10F);
            this.btnRecalc.ForeColor = Color.White;
            this.btnRecalc.BackColor = Color.FromArgb(155, 89, 182);
            this.btnRecalc.FlatAppearance.BorderSize = 0;
            this.btnRecalc.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 68, 173);
            this.btnRecalc.FlatAppearance.MouseDownBackColor = Color.FromArgb(118, 49, 153);
            this.btnRecalc.Location = new Point(250, 420);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new Size(210, 38);
            this.btnRecalc.TabIndex = 17;
            this.btnRecalc.Text = "🔄 Пересчитать риски";
            this.btnRecalc.UseVisualStyleBackColor = false;
            this.btnRecalc.Click += new EventHandler(this.btnRecalc_Click);
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
            this.btnDelete.Location = new Point(475, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(210, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "🗑️ Удалить дефект";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
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
            this.btnClose.Location = new Point(700, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(259, 38);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "❌ Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            // 
            // DefectAnalysisForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.ClientSize = new Size(984, 481);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecalc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtWid);
            this.Controls.Add(this.lblWid);
            this.Controls.Add(this.txtLen);
            this.Controls.Add(this.lblLen);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblCriticalCount);
            this.Controls.Add(this.cbSeverityFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbInspections);
            this.Controls.Add(this.lblInspection);
            this.Name = "DefectAnalysisForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Анализ дефектов";
            this.Load += new EventHandler(this.DefectAnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}