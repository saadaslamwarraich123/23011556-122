using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorWithHistory
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display your name in the title bar
            this.Text = "Calculation History - Your Name"; // ← Replace with your real name

            // Clear the ListBox before adding new items
            lstHistory.Items.Clear();

            // Loop through all saved calculations and show them in the ListBox
            foreach (string item in Result11.HistoryList)
            {
                lstHistory.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close this form and return to the calculator
            this.Close();
        }

        private void lstHistory11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
