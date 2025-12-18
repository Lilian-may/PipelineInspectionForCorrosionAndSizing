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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(80, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(240, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Вход в систему";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new Font("Times New Roman", 12F);
            this.lblLogin.Location = new Point(30, 70);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new Size(50, 19);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new Font("Times New Roman", 12F);
            this.txtLogin.Location = new Point(30, 92);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(340, 26);
            this.txtLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Times New Roman", 12F);
            this.lblPassword.Location = new Point(30, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(58, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Times New Roman", 12F);
            this.txtPassword.Location = new Point(30, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new Size(340, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            this.btnLogin.Location = new Point(30, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(160, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.Font = new Font("Times New Roman", 11F);
            this.btnCreateAdmin.Location = new Point(210, 200);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new Size(160, 40);
            this.btnCreateAdmin.TabIndex = 6;
            this.btnCreateAdmin.Text = "Создать Admin";
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Visible = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 270);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
