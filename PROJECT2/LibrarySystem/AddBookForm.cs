using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LibrarySystem
{
    internal class AddBookForm : Form
    {
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label lblStatus;

        public AddBookForm()
        {
            Text = "Add Book";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(380, 230);
            Initialize();
        }

        private void Initialize()
        {
            Label lTitle = new Label { Text = "Title:", Location = new Point(20, 20), AutoSize = true };
            txtTitle = new TextBox { Location = new Point(100, 18), Width = 240 };
            Label lAuthor = new Label { Text = "Author:", Location = new Point(20, 60), AutoSize = true };
            txtAuthor = new TextBox { Location = new Point(100, 58), Width = 240 };

            Button btnSave = new Button { Text = "Save", Location = new Point(100, 100), Size = new Size(100, 36) };
            btnSave.Click += BtnSave_Click;

            lblStatus = new Label { Location = new Point(20, 150), AutoSize = true, ForeColor = Color.Green };

            Controls.AddRange(new Control[] { lTitle, txtTitle, lAuthor, txtAuthor, btnSave, lblStatus });
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a book title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }
            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please enter author name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return;
            }

            DataStore.Books.Add(new Book { Title = title, Author = author, Available = true });
            lblStatus.Text = "Book added successfully.";

            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtTitle.Focus();
        }
    }
}
