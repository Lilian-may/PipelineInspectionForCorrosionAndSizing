using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp2
{
    partial class AuthenticationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCreateAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblLogin = new Label();
            this.lblPassword = new Label();
            this.txtLogin = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnCreateAdmin = new Button();
            this.SuspendLayout();

            // AuthenticationForm - Clean login card
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(400, 320);
            this.Controls.Add(this.btnCreateAdmin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthenticationForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Аутентификация";
            this.Load += new System.EventHandler(this.AuthenticationForm_Load);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTitle.Location = new Point(80, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(240, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Вход в систему";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblLogin
            //
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblLogin.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblLogin.Location = new Point(40, 95);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new Size(50, 19);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPassword.ForeColor = Color.FromArgb(52, 73, 94);
            this.lblPassword.Location = new Point(40, 155);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(58, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            //
            // txtLogin
            //
            this.txtLogin.Font = new Font("Segoe UI", 11F);
            this.txtLogin.Location = new Point(40, 117);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(320, 27);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.BorderStyle = BorderStyle.FixedSingle;
            this.txtLogin.Padding = new Padding(5);
            //
            // txtPassword
            //
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.txtPassword.Location = new Point(40, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new Size(320, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.Padding = new Padding(5);
            //
            // btnLogin
            //
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            this.btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 140);
            this.btnLogin.Location = new Point(40, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(150, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "🔑 Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            //
            // btnCreateAdmin
            //
            this.btnCreateAdmin.FlatStyle = FlatStyle.Flat;
            this.btnCreateAdmin.Font = new Font("Segoe UI", 10F);
            this.btnCreateAdmin.ForeColor = Color.FromArgb(52, 73, 94);
            this.btnCreateAdmin.BackColor = Color.White;
            this.btnCreateAdmin.FlatAppearance.BorderColor = Color.FromArgb(189, 195, 199);
            this.btnCreateAdmin.FlatAppearance.BorderSize = 1;
            this.btnCreateAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 247, 250);
            this.btnCreateAdmin.Location = new Point(210, 230);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new Size(150, 42);
            this.btnCreateAdmin.TabIndex = 6;
            this.btnCreateAdmin.Text = "⚙️ Создать Admin";
            this.btnCreateAdmin.UseVisualStyleBackColor = false;
            this.btnCreateAdmin.Visible = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
