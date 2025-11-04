using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginProject11
{
    public partial class HomePage : Form
    {
        private string username;

        public HomePage(string user)
        {
            InitializeComponent();
            username = user;
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            txtWelcome.Text = $"Welcome, {username}!";
            this.BackColor = System.Drawing.Color.LightGreen; // Originality parameter
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(); login.Show();
        }

        private void txtWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}