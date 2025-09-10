namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button0, button1, button2, button3, button4, button5, button6, button7, button8, button9;
        private Button buttonClear, buttonParen, buttonPercent, buttonSign, buttonDot;
        private Button btnDivide, btnMultiply, btnMinus, btnPlus, btnEquals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new TextBox();

            this.button0 = new Button();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();

            this.buttonClear = new Button();
            this.buttonParen = new Button();
            this.buttonPercent = new Button();
            this.buttonSign = new Button();
            this.buttonDot = new Button();

            this.btnDivide = new Button();
            this.btnMultiply = new Button();
            this.btnMinus = new Button();
            this.btnPlus = new Button();
            this.btnEquals = new Button();

            this.SuspendLayout();

            // textBox1 (single display)
            this.textBox1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            this.textBox1.BackColor = Color.White;
            this.textBox1.BorderStyle = BorderStyle.None;
            this.textBox1.TextAlign = HorizontalAlignment.Right;
            this.textBox1.Location = new Point(12, 12);
            this.textBox1.Size = new Size(310, 55);
            this.textBox1.ReadOnly = true;

            // Base button style
            int btnSize = 70;
            Font btnFont = new Font("Segoe UI", 14F, FontStyle.Bold);

            void StyleButton(Button btn, string text, int x, int y, EventHandler handler, bool isOperator = false, int width = 70)
            {
                btn.Font = btnFont;
                btn.Text = text;
                btn.Size = new Size(width, btnSize);
                btn.Location = new Point(x, y);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = isOperator ? Color.Orange : Color.FromArgb(230, 230, 230);
                btn.ForeColor = isOperator ? Color.White : Color.Black;
                btn.Click += handler;
            }

            int startX = 12, startY = 90, gap = 5;

            // Top row (C, (), %, ÷)
            StyleButton(buttonClear, "C", startX, startY, BtnClear_Click);
            StyleButton(buttonParen, "( )", startX + (btnSize + gap), startY, BtnParen_Click); 
            StyleButton(buttonPercent, "%", startX + 2 * (btnSize + gap), startY, Special_Click);
            StyleButton(btnDivide, "÷", startX + 3 * (btnSize + gap), startY, Operator_Click, true);

            // Row 7 8 9 ×
            StyleButton(button7, "7", startX, startY + (btnSize + gap), Number_Click);
            StyleButton(button8, "8", startX + (btnSize + gap), startY + (btnSize + gap), Number_Click);
            StyleButton(button9, "9", startX + 2 * (btnSize + gap), startY + (btnSize + gap), Number_Click);
            StyleButton(btnMultiply, "×", startX + 3 * (btnSize + gap), startY + (btnSize + gap), Operator_Click, true);

            // Row 4 5 6 -
            StyleButton(button4, "4", startX, startY + 2 * (btnSize + gap), Number_Click);
            StyleButton(button5, "5", startX + (btnSize + gap), startY + 2 * (btnSize + gap), Number_Click);
            StyleButton(button6, "6", startX + 2 * (btnSize + gap), startY + 2 * (btnSize + gap), Number_Click);
            StyleButton(btnMinus, "-", startX + 3 * (btnSize + gap), startY + 2 * (btnSize + gap), Operator_Click, true);

            // Row 1 2 3 +
            StyleButton(button1, "1", startX, startY + 3 * (btnSize + gap), Number_Click);
            StyleButton(button2, "2", startX + (btnSize + gap), startY + 3 * (btnSize + gap), Number_Click);
            StyleButton(button3, "3", startX + 2 * (btnSize + gap), startY + 3 * (btnSize + gap), Number_Click);
            StyleButton(btnPlus, "+", startX + 3 * (btnSize + gap), startY + 3 * (btnSize + gap), Operator_Click, true);

            // Row ± 0 . =
            StyleButton(buttonSign, "±", startX, startY + 4 * (btnSize + gap), BtnSign_Click);
            StyleButton(button0, "0", startX + (btnSize + gap), startY + 4 * (btnSize + gap), Number_Click, false, width: 140);
            StyleButton(buttonDot, ".", startX + 2 * (btnSize + gap) + gap, startY + 4 * (btnSize + gap), Special_Click);
            StyleButton(btnEquals, "=", startX + 3 * (btnSize + gap), startY + 4 * (btnSize + gap), BtnEquals_Click, true);

            // Form
            this.ClientSize = new Size(340, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.AddRange(new Control[] {
                buttonClear, buttonParen, buttonPercent, btnDivide,
                button7, button8, button9, btnMultiply,
                button4, button5, button6, btnMinus,
                button1, button2, button3, btnPlus,
                buttonSign, button0, buttonDot, btnEquals
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Modern Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
