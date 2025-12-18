using System;
using System.Windows.Forms;
using System.Drawing;

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
            this.lblInspection.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.lblInspection.Location = new Point(20, 20);
            this.lblInspection.Name = "lblInspection";
            this.lblInspection.Size = new Size(88, 19);
            this.lblInspection.TabIndex = 0;
            this.lblInspection.Text = "Инспекция:";
            // 
            // cbInspections
            // 
            this.cbInspections.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbInspections.Font = new Font("Times New Roman", 11F);
            this.cbInspections.FormattingEnabled = true;
            this.cbInspections.Location = new Point(120, 18);
            this.cbInspections.Name = "cbInspections";
            this.cbInspections.Size = new Size(600, 25);
            this.cbInspections.TabIndex = 1;
            this.cbInspections.SelectionChangeCommitted += new EventHandler(this.cbInspections_SelectionChangeCommitted);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new Font("Times New Roman", 11F);
            this.lblFilter.Location = new Point(740, 22);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new Size(62, 17);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Фильтр:";
            // 
            // cbSeverityFilter
            // 
            this.cbSeverityFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSeverityFilter.Font = new Font("Times New Roman", 11F);
            this.cbSeverityFilter.FormattingEnabled = true;
            this.cbSeverityFilter.Items.AddRange(new object[] { "Все", "Low", "Medium", "High", "Critical" });
            this.cbSeverityFilter.Location = new Point(810, 19);
            this.cbSeverityFilter.Name = "cbSeverityFilter";
            this.cbSeverityFilter.Size = new Size(150, 25);
            this.cbSeverityFilter.TabIndex = 3;
            this.cbSeverityFilter.SelectionChangeCommitted += new EventHandler(this.cbSeverityFilter_SelectionChangeCommitted);
            // 
            // lblCriticalCount
            // 
            this.lblCriticalCount.AutoSize = true;
            this.lblCriticalCount.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            this.lblCriticalCount.ForeColor = Color.Red;
            this.lblCriticalCount.Location = new Point(20, 55);
            this.lblCriticalCount.Name = "lblCriticalCount";
            this.lblCriticalCount.Size = new Size(124, 17);
            this.lblCriticalCount.TabIndex = 4;
            this.lblCriticalCount.Text = "Критических: 0";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new Point(20, 85);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new Size(940, 280);
            this.dgv.TabIndex = 5;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new Font("Times New Roman", 10F);
            this.lblKm.Location = new Point(20, 385);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new Size(53, 16);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "Км (км):";
            // 
            // txtKm
            // 
            this.txtKm.Font = new Font("Times New Roman", 10F);
            this.txtKm.Location = new Point(80, 382);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new Size(90, 23);
            this.txtKm.TabIndex = 7;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new Font("Times New Roman", 10F);
            this.lblDepth.Location = new Point(185, 385);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new Size(82, 16);
            this.lblDepth.TabIndex = 8;
            this.lblDepth.Text = "Глубина (%):";
            // 
            // txtDepth
            // 
            this.txtDepth.Font = new Font("Times New Roman", 10F);
            this.txtDepth.Location = new Point(270, 382);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new Size(80, 23);
            this.txtDepth.TabIndex = 9;
            // 
            // lblLen
            // 
            this.lblLen.AutoSize = true;
            this.lblLen.Font = new Font("Times New Roman", 10F);
            this.lblLen.Location = new Point(365, 385);
            this.lblLen.Name = "lblLen";
            this.lblLen.Size = new Size(80, 16);
            this.lblLen.TabIndex = 10;
            this.lblLen.Text = "Длина (мм):";
            // 
            // txtLen
            // 
            this.txtLen.Font = new Font("Times New Roman", 10F);
            this.txtLen.Location = new Point(450, 382);
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new Size(80, 23);
            this.txtLen.TabIndex = 11;
            // 
            // lblWid
            // 
            this.lblWid.AutoSize = true;
            this.lblWid.Font = new Font("Times New Roman", 10F);
            this.lblWid.Location = new Point(545, 385);
            this.lblWid.Name = "lblWid";
            this.lblWid.Size = new Size(86, 16);
            this.lblWid.TabIndex = 12;
            this.lblWid.Text = "Ширина (мм):";
            // 
            // txtWid
            // 
            this.txtWid.Font = new Font("Times New Roman", 10F);
            this.txtWid.Location = new Point(635, 382);
            this.txtWid.Name = "txtWid";
            this.txtWid.Size = new Size(80, 23);
            this.txtWid.TabIndex = 13;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new Font("Times New Roman", 10F);
            this.lblType.Location = new Point(730, 385);
            this.lblType.Name = "lblType";
            this.lblType.Size = new Size(33, 16);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Тип:";
            // 
            // txtType
            // 
            this.txtType.Font = new Font("Times New Roman", 10F);
            this.txtType.Location = new Point(770, 382);
            this.txtType.Name = "txtType";
            this.txtType.Size = new Size(190, 23);
            this.txtType.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            this.btnAdd.Location = new Point(20, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(220, 35);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить дефект";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnRecalc
            // 
            this.btnRecalc.Font = new Font("Times New Roman", 11F);
            this.btnRecalc.Location = new Point(260, 425);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new Size(220, 35);
            this.btnRecalc.TabIndex = 17;
            this.btnRecalc.Text = "Пересчитать риски";
            this.btnRecalc.UseVisualStyleBackColor = true;
            this.btnRecalc.Click += new EventHandler(this.btnRecalc_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new Font("Times New Roman", 11F);
            this.btnDelete.Location = new Point(500, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(220, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить дефект";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new Font("Times New Roman", 11F);
            this.btnClose.Location = new Point(740, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(220, 35);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            // 
            // DefectAnalysisForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
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
