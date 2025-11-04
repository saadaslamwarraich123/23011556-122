using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace SimpleCalculatorWithHistory
{
    public partial class Result11 : Form
    {// Shared history list to store calculations
        public static List<string> HistoryList = new List<string>();

        public Result11()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            // Show your name in the title bar
            this.Text = "Simple Calculator - Your Name"; // ← Replace with your name
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Calculate("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculate("/");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Open the history form
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }
        private void Calculate(string operation)
        {
            double num1, num2, result = 0;

            // Validate inputs
            if (!double.TryParse(txtNumber1.Text, out num1) || !double.TryParse(txtNumber2.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            txtResult.Text = result.ToString();

            // Save to history
            string record = $"{num1} {operation} {num2} = {result}";
            HistoryList.Add(record);
        }

        private void txtNumber11_Click(object sender, EventArgs e)
        {

        }

        private void Result11_Load(object sender, EventArgs e)
        {

        }
    }
}