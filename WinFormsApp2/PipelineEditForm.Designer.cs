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
            // PipelineEditForm - Clean Edit Card
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 247, 250);
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
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblName.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblName.Location = new Point(25, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(107, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            //
            // txtName
            //
            this.txtName.Font = new Font("Segoe UI", 10F);
            this.txtName.Location = new Point(25, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(450, 25);
            this.txtName.TabIndex = 1;
            this.txtName.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblDiameter
            //
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblDiameter.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblDiameter.Location = new Point(25, 85);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new Size(101, 19);
            this.lblDiameter.TabIndex = 2;
            this.lblDiameter.Text = "Диаметр (мм)";
            //
            // txtDiameter
            //
            this.txtDiameter.Font = new Font("Segoe UI", 10F);
            this.txtDiameter.Location = new Point(25, 107);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new Size(200, 25);
            this.txtDiameter.TabIndex = 3;
            this.txtDiameter.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblLength
            //
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblLength.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblLength.Location = new Point(25, 145);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new Size(78, 19);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Длина (км)";
            //
            // txtLength
            //
            this.txtLength.Font = new Font("Segoe UI", 10F);
            this.txtLength.Location = new Point(25, 167);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new Size(200, 25);
            this.txtLength.TabIndex = 5;
            this.txtLength.BorderStyle = BorderStyle.FixedSingle;
            //
            // lblMaterial
            //
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblMaterial.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblMaterial.Location = new Point(25, 205);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new Size(77, 19);
            this.lblMaterial.TabIndex = 6;
            this.lblMaterial.Text = "Материал";
            //
            // cbMaterial
            //
            this.cbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbMaterial.Font = new Font("Segoe UI", 10F);
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new Point(25, 227);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new Size(300, 25);
            this.cbMaterial.TabIndex = 7;
            this.cbMaterial.FlatStyle = FlatStyle.Popup;
            //
            // lblPressure
            //
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPressure.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblPressure.Location = new Point(25, 265);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new Size(112, 19);
            this.lblPressure.TabIndex = 8;
            this.lblPressure.Text = "Давление (МПа)";
            //
            // txtPressure
            //
            this.txtPressure.Font = new Font("Segoe UI", 10F);
            this.txtPressure.Location = new Point(25, 287);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new Size(200, 25);
            this.txtPressure.TabIndex = 9;
            this.txtPressure.BorderStyle = BorderStyle.FixedSingle;
            //
            // btnSave
            //
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.BackColor = Color.FromArgb(46, 204, 113);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            this.btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 136, 76);
            this.btnSave.Location = new Point(25, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(140, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnCancel
            //
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 140, 141);
            this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 106, 106);
            this.btnCancel.Location = new Point(180, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(140, 38);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "❌ Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // PipelineEditForm
            //
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}