using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagement
{
    public class DashboardForm : Form
    {
        private Button btnAdd;
        private Button btnView;
        private Button btnExit;

        public DashboardForm()
        {
            Text = "Student System by Mohib Ali"; // Originality title
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(420, 200);
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Label lblTitle = new Label
            {
                Text = "Dashboard",
                Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };

            btnAdd = new Button { Text = "Add Student", Location = new Point(20, 60), Size = new Size(120, 40) };
            btnView = new Button { Text = "View Students", Location = new Point(150, 60), Size = new Size(120, 40) };
            btnExit = new Button { Text = "Exit", Location = new Point(280, 60), Size = new Size(80, 40) };

            btnAdd.Click += BtnAdd_Click;
            btnView.Click += BtnView_Click;
            btnExit.Click += BtnExit_Click;

            Controls.Add(lblTitle);
            Controls.Add(btnAdd);
            Controls.Add(btnView);
            Controls.Add(btnExit);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddStudentForm().ShowDialog();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            new ViewStudentsForm().ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
