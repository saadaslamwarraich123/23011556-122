using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public class BorrowBookForm : Form
    {
        private DataGridView dgv;
        private Button btnBorrow;
        private Label lblInfo;

        public BorrowBookForm()
        {
            Text = "Borrow Book";
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

            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title", Width = 300 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Author", DataPropertyName = "Author", Width = 200 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Available", DataPropertyName = "Available", Width = 120 });

            dgv.DataSource = DataStore.Books;

            btnBorrow = new Button { Text = "Borrow Selected Book", Location = new Point(10, 320), Size = new Size(200, 36) };
            btnBorrow.Click += BtnBorrow_Click;

            lblInfo = new Label { Location = new Point(230, 325), AutoSize = true };

            Controls.AddRange(new Control[] { dgv, btnBorrow, lblInfo });
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a book to borrow.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var book = dgv.SelectedRows[0].DataBoundItem as Book;
            if (book == null) return;

            if (!book.Available)
            {
                MessageBox.Show("This book is already borrowed/unavailable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            book.Available = false;
            DataStore.BorrowedBooks.Add(book);
            dgv.Refresh();

            lblInfo.Text = $"You borrowed: {book.Title}";
        }
    }
}
