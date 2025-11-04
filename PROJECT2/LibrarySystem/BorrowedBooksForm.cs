using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public class BorrowedBooksForm : Form
    {
        private DataGridView dgv;
        private Button btnReturn;
        private Button btnClose;

        public BorrowedBooksForm()
        {
            Text = "Borrowed Books";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(700, 420);
            Initialize();
        }

        private void Initialize()
        {
            dgv = new DataGridView
            {
                Location = new Point(10, 10),
                Size = new Size(660, 300),
                ReadOnly = true,
                AutoGenerateColumns = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false
            };

            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title", Width = 320 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Author", DataPropertyName = "Author", Width = 260 });

            dgv.DataSource = DataStore.BorrowedBooks;

            btnReturn = new Button { Text = "Return Selected Book", Location = new Point(10, 320), Size = new Size(180, 36) };
            btnReturn.Click += BtnReturn_Click;

            btnClose = new Button { Text = "Close", Location = new Point(500, 320), Size = new Size(120, 36) };
            btnClose.Click += (s, e) => Close();

            Controls.AddRange(new Control[] { dgv, btnReturn, btnClose });
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a borrowed book to return.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var book = dgv.SelectedRows[0].DataBoundItem as Book;
            if (book == null) return;

            var confirm = MessageBox.Show($"Return '{book.Title}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            book.Available = true;
            DataStore.BorrowedBooks.Remove(book);
            dgv.Refresh();
        }
    }
}
