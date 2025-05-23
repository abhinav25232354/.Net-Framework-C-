namespace GUI_2___Calculator
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
            sum_num1 = new TextBox();
            sum_num2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            sum_result = new TextBox();
            label2 = new Label();
            label3 = new Label();
            sub_num_1 = new TextBox();
            sub_num_2 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            sub_result = new TextBox();
            label5 = new Label();
            mul_num1 = new TextBox();
            mul_num2 = new TextBox();
            button3 = new Button();
            label6 = new Label();
            mul_result = new TextBox();
            label7 = new Label();
            div_num1 = new TextBox();
            div_num2 = new TextBox();
            div_result = new TextBox();
            label8 = new Label();
            button4 = new Button();
            Error = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // sum_num1
            // 
            sum_num1.Location = new Point(12, 36);
            sum_num1.Name = "sum_num1";
            sum_num1.Size = new Size(100, 23);
            sum_num1.TabIndex = 0;
            // 
            // sum_num2
            // 
            sum_num2.Location = new Point(12, 65);
            sum_num2.Name = "sum_num2";
            sum_num2.Size = new Size(100, 23);
            sum_num2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Addition";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Sum";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sum_result
            // 
            sum_result.Location = new Point(12, 171);
            sum_result.Name = "sum_result";
            sum_result.Size = new Size(100, 23);
            sum_result.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 18);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Subtraction";
            // 
            // sub_num_1
            // 
            sub_num_1.Location = new Point(155, 36);
            sub_num_1.Name = "sub_num_1";
            sub_num_1.Size = new Size(100, 23);
            sub_num_1.TabIndex = 7;
            // 
            // sub_num_2
            // 
            sub_num_2.Location = new Point(155, 65);
            sub_num_2.Name = "sub_num_2";
            sub_num_2.Size = new Size(100, 23);
            sub_num_2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(155, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Subtract";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 153);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Result";
            // 
            // sub_result
            // 
            sub_result.Location = new Point(155, 171);
            sub_result.Name = "sub_result";
            sub_result.Size = new Size(100, 23);
            sub_result.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 18);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 12;
            label5.Text = "Multiplication";
            label5.Click += label5_Click;
            // 
            // mul_num1
            // 
            mul_num1.Location = new Point(303, 36);
            mul_num1.Name = "mul_num1";
            mul_num1.Size = new Size(100, 23);
            mul_num1.TabIndex = 13;
            // 
            // mul_num2
            // 
            mul_num2.Location = new Point(303, 65);
            mul_num2.Name = "mul_num2";
            mul_num2.Size = new Size(100, 23);
            mul_num2.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(303, 94);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Multiply";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 153);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 16;
            label6.Text = "Result";
            // 
            // mul_result
            // 
            mul_result.Location = new Point(303, 171);
            mul_result.Name = "mul_result";
            mul_result.Size = new Size(100, 23);
            mul_result.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 18);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 18;
            label7.Text = "Division";
            // 
            // div_num1
            // 
            div_num1.Location = new Point(452, 36);
            div_num1.Name = "div_num1";
            div_num1.Size = new Size(100, 23);
            div_num1.TabIndex = 19;
            // 
            // div_num2
            // 
            div_num2.Location = new Point(452, 64);
            div_num2.Name = "div_num2";
            div_num2.Size = new Size(100, 23);
            div_num2.TabIndex = 20;
            // 
            // div_result
            // 
            div_result.Location = new Point(452, 171);
            div_result.Name = "div_result";
            div_result.Size = new Size(100, 23);
            div_result.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 153);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 22;
            label8.Text = "Result";
            // 
            // button4
            // 
            button4.Location = new Point(452, 93);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 23;
            button4.Text = "Divide";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Error
            // 
            Error.Location = new Point(12, 228);
            Error.Multiline = true;
            Error.Name = "Error";
            Error.Size = new Size(540, 210);
            Error.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 210);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 25;
            label9.Text = "Errors";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.AppWorkspace;
            label10.Location = new Point(12, 120);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 26;
            label10.Text = "Reset";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.AppWorkspace;
            label11.Location = new Point(155, 120);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 27;
            label11.Text = "Reset";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.AppWorkspace;
            label12.Location = new Point(303, 120);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 28;
            label12.Text = "Reset";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.AppWorkspace;
            label13.Location = new Point(452, 119);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 29;
            label13.Text = "Reset";
            label13.Click += label13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Error);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(div_result);
            Controls.Add(div_num2);
            Controls.Add(div_num1);
            Controls.Add(label7);
            Controls.Add(mul_result);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(mul_num2);
            Controls.Add(mul_num1);
            Controls.Add(label5);
            Controls.Add(sub_result);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(sub_num_2);
            Controls.Add(sub_num_1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sum_result);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(sum_num2);
            Controls.Add(sum_num1);
            Name = "Form1";
            Text = "Calculator by Abhinav";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sum_num1;
        private TextBox sum_num2;
        private Label label1;
        private Button button1;
        private TextBox sum_result;
        private Label label2;
        private Label label3;
        private TextBox sub_num_1;
        private TextBox sub_num_2;
        private Button button2;
        private Label label4;
        private TextBox sub_result;
        private Label label5;
        private TextBox mul_num1;
        private TextBox mul_num2;
        private Button button3;
        private Label label6;
        private TextBox mul_result;
        private Label label7;
        private TextBox div_num1;
        private TextBox div_num2;
        private TextBox div_result;
        private Label label8;
        private Button button4;
        private Label label9;
        public TextBox Error;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
