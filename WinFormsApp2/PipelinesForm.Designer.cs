using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp2
{
    partial class PipelinesForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblRole;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgv;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnOpenInspections;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblRole = new Label();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.dgv = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnOpenInspections = new Button();
            this.btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new Font("Times New Roman", 12F);
            this.lblRole.Location = new Point(20, 20);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new Size(100, 19);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Роль: Operator";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new Font("Times New Roman", 12F);
            this.txtSearch.Location = new Point(20, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Поиск по наименованию...";
            this.txtSearch.Size = new Size(400, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new Font("Times New Roman", 12F);
            this.btnSearch.Location = new Point(435, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new Point(20, 100);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new Size(940, 400);
            this.dgv.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.btnAdd.Location = new Point(20, 520);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(180, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new Font("Times New Roman", 12F);
            this.btnEdit.Location = new Point(220, 520);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(180, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new Font("Times New Roman", 12F);
            this.btnDelete.Location = new Point(420, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(180, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenInspections
            // 
            this.btnOpenInspections.Font = new Font("Times New Roman", 12F);
            this.btnOpenInspections.Location = new Point(620, 520);
            this.btnOpenInspections.Name = "btnOpenInspections";
            this.btnOpenInspections.Size = new Size(180, 40);
            this.btnOpenInspections.TabIndex = 7;
            this.btnOpenInspections.Text = "Инспекции →";
            this.btnOpenInspections.UseVisualStyleBackColor = true;
            this.btnOpenInspections.Click += new System.EventHandler(this.btnOpenInspections_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new Font("Times New Roman", 12F);
            this.btnClose.Location = new Point(820, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(140, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PipelinesForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(984, 591);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenInspections);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblRole);
            this.Name = "PipelinesForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Трубопроводы";
            this.Load += new System.EventHandler(this.PipelinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
