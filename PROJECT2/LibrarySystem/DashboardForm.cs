using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public class DashboardForm : Form
    {
        public DashboardForm()
        {
            Text = "Library Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(500, 240);
            Initialize();
        }

        private void Initialize()
        {
            Label title = new Label
            {
                Text = "Main Dashboard",
                Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold),
                Location = new Point(20, 15),
                AutoSize = true
            };

            Button btnAdd = new Button { Text = "Add Book", Location = new Point(20, 60), Size = new Size(140, 50), BackColor = Color.LightGreen };
            Button btnBorrow = new Button { Text = "Borrow Book", Location = new Point(180, 60), Size = new Size(140, 50) };
            Button btnView = new Button { Text = "View Borrowed Books", Location = new Point(340, 60), Size = new Size(140, 50) };

            btnAdd.Click += (s, e) => new AddBookForm().ShowDialog(this);
            btnBorrow.Click += (s, e) => new BorrowBookForm().ShowDialog(this);
            btnView.Click += (s, e) => new BorrowedBooksForm().ShowDialog(this);

            Controls.AddRange(new Control[] { title, btnAdd, btnBorrow, btnView });
        }
    }
}
