using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagement
{
    public class ViewStudentsForm : Form
    {
        private DataGridView dgv;
        private Button btnClose;
        private Button btnDeleteSelected;

        public ViewStudentsForm()
        {
            Text = "View Students";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(640, 400);
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            dgv = new DataGridView
            {
                Location = new Point(10, 10),
                Size = new Size(610, 300),
                AutoGenerateColumns = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AllowUserToAddRows = false,
                DataSource = DataStore.Students
            };

            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 180 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name", Width = 180 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Age", DataPropertyName = "Age", Width = 80 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Class", DataPropertyName = "Class", Width = 140 });

            btnDeleteSelected = new Button { Text = "Delete Selected", Location = new Point(10, 320), Size = new Size(120, 30) };
            btnDeleteSelected.Click += BtnDeleteSelected_Click;

            btnClose = new Button { Text = "Close", Location = new Point(500, 320), Size = new Size(120, 30) };
            btnClose.Click += (s, e) => Close();

            Controls.Add(dgv);
            Controls.Add(btnDeleteSelected);
            Controls.Add(btnClose);
        }

        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a student to delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var student = dgv.SelectedRows[0].DataBoundItem as Student;
            if (student == null) return;

            var res = MessageBox.Show($"Are you sure you want to delete '{student.Name}'?",
                                      "Confirm Delete",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
                DataStore.Students.Remove(student);
        }
    }
}
