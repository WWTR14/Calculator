namespace Calculator
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn0 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(85, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(497, 97);
            txtTotal.TabIndex = 1;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(85, 117);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 66);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(400, 211);
            btn9.Name = "btn9";
            btn9.Size = new Size(86, 72);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(296, 209);
            btn8.Name = "btn8";
            btn8.Size = new Size(98, 74);
            btn8.TabIndex = 4;
            btn8.Text = "6";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button3_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(296, 117);
            btn3.Name = "btn3";
            btn3.Size = new Size(98, 66);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(492, 113);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 69);
            btn5.TabIndex = 6;
            btn5.Text = "8";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button5_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(188, 208);
            btn7.Name = "btn7";
            btn7.Size = new Size(93, 76);
            btn7.TabIndex = 7;
            btn7.Text = "5";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button6_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(188, 116);
            btn2.Name = "btn2";
            btn2.Size = new Size(93, 66);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(400, 116);
            btn4.Name = "btn4";
            btn4.Size = new Size(86, 69);
            btn4.TabIndex = 9;
            btn4.Text = "7";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(85, 207);
            btn6.Name = "btn6";
            btn6.Size = new Size(89, 76);
            btn6.TabIndex = 10;
            btn6.Text = "4";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(498, 210);
            btn0.Name = "btn0";
            btn0.Size = new Size(84, 74);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button10_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(197, 308);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(84, 74);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(90, 308);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(84, 74);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(402, 308);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(84, 74);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(296, 308);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(98, 74);
            btnMult.TabIndex = 16;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(498, 308);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 74);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(90, 388);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(492, 55);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 483);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btn0);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn9;
        private Button btn8;
        private Button btn3;
        private Button btn5;
        private Button btn7;
        private Button btn2;
        private Button btn4;
        private Button btn6;
        private Button btn0;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnDiv;
        private Button btnMult;
        private Button btnClear;
        private Button btnEqual;
    }
}
