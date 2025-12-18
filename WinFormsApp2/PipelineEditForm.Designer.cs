using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp2
{
    partial class PipelineEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private Label lblDiameter;
        private Label lblLength;
        private Label lblMaterial;
        private Label lblPressure;
        private TextBox txtName;
        private TextBox txtDiameter;
        private TextBox txtLength;
        private ComboBox cbMaterial;
        private TextBox txtPressure;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.lblDiameter = new Label();
            this.lblLength = new Label();
            this.lblMaterial = new Label();
            this.lblPressure = new Label();
            this.txtName = new TextBox();
            this.txtDiameter = new TextBox();
            this.txtLength = new TextBox();
            this.cbMaterial = new ComboBox();
            this.txtPressure = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new Font("Times New Roman", 12F);
            this.lblName.Location = new Point(18, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(107, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // txtName
            // 
            this.txtName.Font = new Font("Times New Roman", 12F);
            this.txtName.Location = new Point(18, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(460, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new Font("Times New Roman", 12F);
            this.lblDiameter.Location = new Point(18, 78);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new Size(101, 19);
            this.lblDiameter.TabIndex = 2;
            this.lblDiameter.Text = "Диаметр (мм)";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Font = new Font("Times New Roman", 12F);
            this.txtDiameter.Location = new Point(18, 100);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new Size(200, 26);
            this.txtDiameter.TabIndex = 3;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new Font("Times New Roman", 12F);
            this.lblLength.Location = new Point(18, 138);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new Size(78, 19);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Длина (км)";
            // 
            // txtLength
            // 
            this.txtLength.Font = new Font("Times New Roman", 12F);
            this.txtLength.Location = new Point(18, 160);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new Size(200, 26);
            this.txtLength.TabIndex = 5;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new Font("Times New Roman", 12F);
            this.lblMaterial.Location = new Point(18, 198);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new Size(77, 19);
            this.lblMaterial.TabIndex = 6;
            this.lblMaterial.Text = "Материал";
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbMaterial.Font = new Font("Times New Roman", 12F);
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new Point(18, 220);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new Size(300, 27);
            this.cbMaterial.TabIndex = 7;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new Font("Times New Roman", 12F);
            this.lblPressure.Location = new Point(18, 258);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new Size(112, 19);
            this.lblPressure.TabIndex = 8;
            this.lblPressure.Text = "Давление (МПа)";
            // 
            // txtPressure
            // 
            this.txtPressure.Font = new Font("Times New Roman", 12F);
            this.txtPressure.Location = new Point(18, 280);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new Size(200, 26);
            this.txtPressure.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.btnSave.Location = new Point(18, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(140, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new Font("Times New Roman", 12F);
            this.btnCancel.Location = new Point(170, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(140, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PipelineEditForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 390);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PipelineEditForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Трубопровод";
            this.Load += new System.EventHandler(this.PipelineEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
