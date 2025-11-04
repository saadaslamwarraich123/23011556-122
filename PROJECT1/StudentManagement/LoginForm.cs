using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagement
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblInfo;

        private const string USER = "admin";
        private const string PASS = "12345";

        public LoginForm()
        {
            Text = "Login - Student Management";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(360, 220);
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Label lblUser = new Label { Text = "Username:", Location = new Point(20, 20), AutoSize = true };
            txtUsername = new TextBox { Location = new Point(100, 18), Width = 200 };

            Label lblPass = new Label { Text = "Password:", Location = new Point(20, 60), AutoSize = true };
            txtPassword = new TextBox { Location = new Point(100, 58), Width = 200, UseSystemPasswordChar = true };

            btnLogin = new Button { Text = "Login", Location = new Point(100, 100), Width = 80 };
            btnLogin.Click += BtnLogin_Click;

            lblInfo = new Label { Location = new Point(20, 140), AutoSize = true, ForeColor = Color.Red };

            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblInfo);

            AcceptButton = btnLogin;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == USER && txtPassword.Text == PASS)
            {
                var dashboard = new DashboardForm();
                dashboard.FormClosed += (s, args) => Application.Exit();
                dashboard.Show();
                Hide();
            }
            else
            {
                lblInfo.Text = "Invalid username or password.";
            }
        }
    }
}
