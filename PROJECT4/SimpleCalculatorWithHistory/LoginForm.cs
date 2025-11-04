using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Display your name in the title bar
            this.Text = "Login Page - Your Name"; // ← Replace "Your Name" with your actual name
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Simple username/password check
            if (username == "admin" && password == "123")
            {
                // Open the calculator form
                Result11 calcForm = new Result11();
                calcForm.Show();
                this.Hide();
            }
            else
            {
                // Invalid login message
                MessageBox.Show("Invalid username or password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Show your name in the title bar (optional)
            this.Text = "Login Page - Your Name"; // replace with your name
        }

    }
}
