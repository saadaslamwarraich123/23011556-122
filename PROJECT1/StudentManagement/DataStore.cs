using System.ComponentModel;

namespace StudentManagement
{
    public static class DataStore
    {
        // BindingList automatically updates DataGridView
        public static BindingList<Student> Students { get; } = new BindingList<Student>();
    }
}
