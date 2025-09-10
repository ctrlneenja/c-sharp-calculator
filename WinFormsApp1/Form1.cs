using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool insertOpenParen = true; // toggle for parentheses

        public Form1()
        {
            InitializeComponent();
        }

        // Handle number button clicks
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        // Handle operator button clicks (+, -, ×, ÷, etc.)
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += " " + btn.Text + " ";
        }

        // Handle dot and percent
        private void Special_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        // Handle parentheses
        private void BtnParen_Click(object sender, EventArgs e)
        {
            if (insertOpenParen)
            {
                textBox1.Text += "(";
            }
            else
            {
                textBox1.Text += ")";
            }

            insertOpenParen = !insertOpenParen;
        }

        // Handle ± sign toggle
        private void BtnSign_Click(object sender, EventArgs e)
        {
            string expr = textBox1.Text;

            if (string.IsNullOrWhiteSpace(expr)) return;

            // Find last number in expression
            int i = expr.Length - 1;
            while (i >= 0 && (char.IsDigit(expr[i]) || expr[i] == '.'))
                i--;

            string before = expr.Substring(0, i + 1);
            string number = expr.Substring(i + 1);

            if (string.IsNullOrEmpty(number)) return;

            if (number.StartsWith("-"))
            {
                // remove minus
                number = number.Substring(1);
            }
            else
            {
                // add minus
                number = "-" + number;
            }

            textBox1.Text = before + number;
        }

        // Clear
        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            insertOpenParen = true;
        }

        // Evaluate expression with PEMDAS
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;

                // Replace symbols with valid operators
                expression = expression.Replace("×", "*").Replace("÷", "/");

                // Use DataTable to compute respecting PEMDAS
                var result = new DataTable().Compute(expression, null);

                textBox1.Text = result.ToString();
                insertOpenParen = true; // reset parentheses state
            }
            catch
            {
                MessageBox.Show("Invalid Expression", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
