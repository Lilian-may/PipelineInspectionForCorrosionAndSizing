using System;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp2
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {
            var adminCount = Db.Scalar("SELECT COUNT(*) FROM users WHERE role='Admin'");
            int count = Convert.ToInt32(adminCount);
            btnCreateAdmin.Visible = (count == 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Validators.ValidateLogin(txtLogin.Text);
                Validators.ValidatePassword(txtPassword.Text);

                string login = txtLogin.Text.Trim();
                string passwordHash = Security.HashPassword(txtPassword.Text);

                var dt = Db.QueryTable(
                    "SELECT id, role FROM users WHERE login=@login AND password_hash=@hash",
                    new MySqlParameter("@login", login),
                    new MySqlParameter("@hash", passwordHash)
                );

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var row = dt.Rows[0];
                int userId = Convert.ToInt32(row["id"]);
                string roleStr = row["role"].ToString();

                UserRole role = roleStr == "Admin" ? UserRole.Admin : UserRole.Operator;
                var ctx = new UserContext(userId, login, role);

                var mainForm = new MainForm(ctx);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                Validators.ValidateLogin(txtLogin.Text);
                Validators.ValidatePassword(txtPassword.Text);

                string login = txtLogin.Text.Trim();
                string passwordHash = Security.HashPassword(txtPassword.Text);

                var existing = Db.Scalar("SELECT COUNT(*) FROM users WHERE login=@login",
                    new MySqlParameter("@login", login));

                if (Convert.ToInt32(existing) > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Db.Exec(
                    "INSERT INTO users(login, password_hash, role) VALUES(@login, @hash, 'Admin')",
                    new MySqlParameter("@login", login),
                    new MySqlParameter("@hash", passwordHash)
                );

                MessageBox.Show("Администратор создан. Теперь войдите в систему.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnCreateAdmin.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
