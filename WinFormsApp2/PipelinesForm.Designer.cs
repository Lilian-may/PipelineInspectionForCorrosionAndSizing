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
            // PipelinesForm - Modern Data Management
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 250);
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
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRole.ForeColor = Color.FromArgb(52, 152, 219);
            this.lblRole.Location = new Point(25, 20);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new Size(100, 19);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Роль: Operator";
            //
            // txtSearch
            //
            this.txtSearch.Font = new Font("Segoe UI", 10F);
            this.txtSearch.Location = new Point(25, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Поиск по наименованию...";
            this.txtSearch.Size = new Size(400, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;
            //
            // btnSearch
            //
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font = new Font("Segoe UI", 10F);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 140);
            this.btnSearch.Location = new Point(435, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔍 Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.dgv.Size = new Size(934, 400);
            this.dgv.TabIndex = 3;
            this.dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9F),
                SelectionBackColor = Color.FromArgb(189, 195, 199),
                SelectionForeColor = Color.Black
            };
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
            this.btnAdd.Location = new Point(25, 520);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(180, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "➕ Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnEdit
            //
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.Font = new Font("Segoe UI", 10F);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 140);
            this.btnEdit.Location = new Point(220, 520);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(180, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "✏️ Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Location = new Point(420, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(180, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "🗑️ Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnOpenInspections
            //
            this.btnOpenInspections.FlatStyle = FlatStyle.Flat;
            this.btnOpenInspections.Font = new Font("Segoe UI", 10F);
            this.btnOpenInspections.ForeColor = Color.White;
            this.btnOpenInspections.BackColor = Color.FromArgb(155, 89, 182);
            this.btnOpenInspections.FlatAppearance.BorderSize = 0;
            this.btnOpenInspections.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 68, 173);
            this.btnOpenInspections.FlatAppearance.MouseDownBackColor = Color.FromArgb(118, 49, 153);
            this.btnOpenInspections.Location = new Point(620, 520);
            this.btnOpenInspections.Name = "btnOpenInspections";
            this.btnOpenInspections.Size = new Size(180, 40);
            this.btnOpenInspections.TabIndex = 7;
            this.btnOpenInspections.Text = "📋 Инспекции →";
            this.btnOpenInspections.UseVisualStyleBackColor = false;
            this.btnOpenInspections.Click += new System.EventHandler(this.btnOpenInspections_Click);
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
            this.btnClose.Location = new Point(820, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(140, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "❌ Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // PipelinesForm
            //
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}