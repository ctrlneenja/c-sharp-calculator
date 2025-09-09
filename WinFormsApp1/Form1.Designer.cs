namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();

            // Operator buttons
            btnDivide = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEquals = new Button();

            // Other buttons
            buttonParen = new Button();
            buttonPercent = new Button();
            buttonClear = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button0 = new Button();
            buttonDot = new Button();
            buttonSign = new Button();

            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 35F);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 70);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 160F);
            textBox2.Location = new Point(12, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 291);
            textBox2.TabIndex = 1;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Arial Rounded MT Bold", 9F);
            btnDivide.Location = new Point(232, 104);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(63, 35);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // buttonParen
            // 
            buttonParen.Font = new Font("Arial Rounded MT Bold", 9F);
            buttonParen.Location = new Point(94, 104);
            buttonParen.Name = "buttonParen";
            buttonParen.Size = new Size(63, 35);
            buttonParen.TabIndex = 5;
            buttonParen.Text = "( )";
            buttonParen.UseVisualStyleBackColor = true;
            buttonParen.Click += buttonParen_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.Font = new Font("Arial Rounded MT Bold", 9F);
            buttonPercent.Location = new Point(163, 104);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(63, 35);
            buttonPercent.TabIndex = 6;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.Crimson;
            buttonClear.Location = new Point(25, 104);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(63, 35);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Arial Rounded MT Bold", 9F);
            button7.Location = new Point(25, 159);
            button7.Name = "button7";
            button7.Size = new Size(63, 35);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Arial Rounded MT Bold", 9F);
            button8.Location = new Point(94, 159);
            button8.Name = "button8";
            button8.Size = new Size(63, 35);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Arial Rounded MT Bold", 9F);
            button9.Location = new Point(163, 159);
            button9.Name = "button9";
            button9.Size = new Size(63, 35);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Arial Rounded MT Bold", 9F);
            btnMultiply.Location = new Point(232, 159);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(63, 35);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 9F);
            button4.Location = new Point(25, 217);
            button4.Name = "button4";
            button4.Size = new Size(63, 35);
            button4.TabIndex = 12;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Rounded MT Bold", 9F);
            button5.Location = new Point(94, 217);
            button5.Name = "button5";
            button5.Size = new Size(63, 35);
            button5.TabIndex = 13;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Rounded MT Bold", 9F);
            button6.Location = new Point(163, 217);
            button6.Name = "button6";
            button6.Size = new Size(63, 35);
            button6.TabIndex = 14;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Arial Rounded MT Bold", 9F);
            btnMinus.Location = new Point(232, 217);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(63, 35);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9F);
            button1.Location = new Point(25, 272);
            button1.Name = "button1";
            button1.Size = new Size(63, 35);
            button1.TabIndex = 16;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 9F);
            button2.Location = new Point(94, 272);
            button2.Name = "button2";
            button2.Size = new Size(63, 35);
            button2.TabIndex = 17;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 9F);
            button3.Location = new Point(163, 272);
            button3.Name = "button3";
            button3.Size = new Size(63, 35);
            button3.TabIndex = 18;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Arial Rounded MT Bold", 9F);
            btnPlus.Location = new Point(232, 272);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(63, 35);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // buttonSign
            // 
            buttonSign.Font = new Font("Arial Rounded MT Bold", 9F);
            buttonSign.Location = new Point(25, 327);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(63, 35);
            buttonSign.TabIndex = 20;
            buttonSign.Text = "+/-";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += buttonSign_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Arial Rounded MT Bold", 9F);
            button0.Location = new Point(94, 327);
            button0.Name = "button0";
            button0.Size = new Size(63, 35);
            button0.TabIndex = 21;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Arial Rounded MT Bold", 9F);
            buttonDot.Location = new Point(163, 327);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(63, 35);
            buttonDot.TabIndex = 22;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Orange;
            btnEquals.Font = new Font("Arial Rounded MT Bold", 9F);
            btnEquals.Location = new Point(232, 327);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(63, 35);
            btnEquals.TabIndex = 23;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 394);
            Controls.Add(btnEquals);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(buttonSign);
            Controls.Add(btnPlus);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMinus);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnMultiply);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(buttonClear);
            Controls.Add(buttonPercent);
            Controls.Add(buttonParen);
            Controls.Add(btnDivide);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;

        // Operator buttons
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEquals;

        // Other buttons
        private Button buttonParen;
        private Button buttonPercent;
        private Button buttonClear;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button0;
        private Button buttonDot;
        private Button buttonSign;
    }
}
