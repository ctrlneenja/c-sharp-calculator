using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double result = 0;
        private string currentOperation = "";
        private bool operationPerformed = false;
        private bool isParenthesisOpen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make all calculator buttons round
            foreach (var ctrl in Controls)
            {
                if (ctrl is Button btn)
                {
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, btn.Width, btn.Height);
                    btn.Region = new Region(path);

                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.TabStop = false; // prevents dotted focus rectangle

                    if (btn.Name.StartsWith("btn"))
                    {
                        // Operator buttons
                        btn.BackColor = Color.Orange;
                        btn.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Number buttons
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }

        // ---------- Number buttons ----------
        private void button0_Click(object sender, EventArgs e) => AppendNumber("0");
        private void button1_Click(object sender, EventArgs e) => AppendNumber("1");
        private void button2_Click(object sender, EventArgs e) => AppendNumber("2");
        private void button3_Click(object sender, EventArgs e) => AppendNumber("3");
        private void button4_Click(object sender, EventArgs e) => AppendNumber("4");
        private void button5_Click(object sender, EventArgs e) => AppendNumber("5");
        private void button6_Click(object sender, EventArgs e) => AppendNumber("6");
        private void button7_Click(object sender, EventArgs e) => AppendNumber("7");
        private void button8_Click(object sender, EventArgs e) => AppendNumber("8");
        private void button9_Click(object sender, EventArgs e) => AppendNumber("9");

        private void AppendNumber(string num)
        {
            currentInput += num;
            textBox1.Text = currentInput;
        }

        // ---------- Special buttons ----------
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                textBox1.Text = currentInput;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            currentOperation = "";
            operationPerformed = false;
            textBox1.Text = "0";
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (currentInput.StartsWith("-"))
                currentInput = currentInput.Substring(1);
            else if (!string.IsNullOrEmpty(currentInput))
                currentInput = "-" + currentInput;

            textBox1.Text = currentInput;
        }

        private void buttonParen_Click(object sender, EventArgs e)
        {
            if (isParenthesisOpen)
            {
                currentInput += ")";
                isParenthesisOpen = false;
            }
            else
            {
                currentInput += "(";
                isParenthesisOpen = true;
            }
            textBox1.Text = currentInput;
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(currentInput, out double num))
            {
                num /= 100;
                currentInput = num.ToString();
                textBox1.Text = currentInput;
            }
        }

        // ---------- Operator buttons ----------
        private void btnPlus_Click(object sender, EventArgs e) => SetOperation("+");
        private void btnMinus_Click(object sender, EventArgs e) => SetOperation("-");
        private void btnMultiply_Click(object sender, EventArgs e) => SetOperation("x");
        private void btnDivide_Click(object sender, EventArgs e) => SetOperation("/");

        private void SetOperation(string op)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                result = double.Parse(currentInput);
                currentInput = "";
            }
            currentOperation = op;
            operationPerformed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e) => Evaluate();

        // ---------- Evaluation ----------
        private void Evaluate()
        {
            if (operationPerformed && !string.IsNullOrEmpty(currentInput))
            {
                double secondNumber = double.Parse(currentInput);

                switch (currentOperation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "x":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result /= secondNumber;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                            result = 0;
                        }
                        break;
                }

                textBox1.Text = result.ToString();
                currentInput = result.ToString();
                operationPerformed = false;
            }
        }
    }
}
