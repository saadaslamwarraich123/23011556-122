using System.ComponentModel;

namespace LibrarySystem
{
    public static class DataStore
    {
        public static BindingList<Book> Books { get; } = new BindingList<Book>();
        public static BindingList<Book> BorrowedBooks { get; } = new BindingList<Book>();
    }
}