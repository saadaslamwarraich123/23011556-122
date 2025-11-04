using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public class LoginForm : Form
    {
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblMsg;

        public LoginForm()
        {
            Text = "Library Login";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(360, 220);
            Initialize();
        }

        private void Initialize()
        {
            Label lUser = new Label { Text = "Username:", Location = new Point(20, 20), AutoSize = true };
            txtUser = new TextBox { Location = new Point(100, 18), Width = 220 };

            Label lPass = new Label { Text = "Password:", Location = new Point(20, 60), AutoSize = true };
            txtPass = new TextBox { Location = new Point(100, 58), Width = 220, UseSystemPasswordChar = true };

            Button btnLogin = new Button { Text = "Login", Location = new Point(100, 100), Width = 100 };
            btnLogin.Click += BtnLogin_Click;

            lblMsg = new Label { Location = new Point(20, 140), AutoSize = true, ForeColor = Color.Red };

            Controls.AddRange(new Control[] { lUser, txtUser, lPass, txtPass, btnLogin, lblMsg });
            AcceptButton = btnLogin;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "123")
            {
                var dash = new DashboardForm();
                dash.FormClosed += (s, ev) => Application.Exit();
                dash.Show();
                Hide();
            }
            else
            {
                lblMsg.Text = "Invalid username or password.";
            }
        }
    }
}
