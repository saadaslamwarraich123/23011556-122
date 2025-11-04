using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagement
{
    public class AddStudentForm : Form
    {
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtClass;
        private Button btnSave;
        private Label lblMessage;

        public AddStudentForm()
        {
            Text = "Add Student";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(380, 260);
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Label lblName = new Label { Text = "Name:", Location = new Point(20, 20), AutoSize = true };
            txtName = new TextBox { Location = new Point(100, 18), Width = 240 };

            Label lblAge = new Label { Text = "Age:", Location = new Point(20, 60), AutoSize = true };
            txtAge = new TextBox { Location = new Point(100, 58), Width = 80 };

            Label lblClass = new Label { Text = "Class:", Location = new Point(20, 100), AutoSize = true };
            txtClass = new TextBox { Location = new Point(100, 98), Width = 240 };

            btnSave = new Button { Text = "Save", Location = new Point(100, 140), Width = 100 };
            btnSave.Click += BtnSave_Click;

            lblMessage = new Label { Location = new Point(20, 180), AutoSize = true, ForeColor = Color.Green };

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(lblClass);
            Controls.Add(txtClass);
            Controls.Add(btnSave);
            Controls.Add(lblMessage);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string studentClass = txtClass.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ageText, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(studentClass))
            {
                MessageBox.Show("Please enter class.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = new Student { Name = name, Age = age, Class = studentClass };
            DataStore.Students.Add(student);

            lblMessage.Text = "Student saved successfully.";

            txtName.Clear();
            txtAge.Clear();
            txtClass.Clear();
            txtName.Focus();
        }
    }
}
