using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Optional: Add some default books
            if (DataStore.Books.Count == 0)
            {
                DataStore.Books.Add(new Book { Title = "C# In Depth", Author = "Jon Skeet" });
                DataStore.Books.Add(new Book { Title = "Clean Code", Author = "Robert C. Martin" });
                DataStore.Books.Add(new Book { Title = "The Pragmatic Programmer", Author = "Hunt & Thomas" });
            }

            Application.Run(new LoginForm());
        }
    }
}