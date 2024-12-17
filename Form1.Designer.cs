namespace WinFormsCalculator1
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
            Num1 = new Label();
            Num2 = new Label();
            Result = new Label();
            nNum1 = new MaskedTextBox();
            rResult = new MaskedTextBox();
            nNum2 = new MaskedTextBox();
            result1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.AutoSize = true;
            Num1.Location = new Point(125, 45);
            Num1.Name = "Num1";
            Num1.Size = new Size(40, 15);
            Num1.TabIndex = 0;
            Num1.Text = "Num1";
            // 
            // Num2
            // 
            Num2.AutoSize = true;
            Num2.Location = new Point(122, 75);
            Num2.Name = "Num2";
            Num2.Size = new Size(43, 15);
            Num2.TabIndex = 1;
            Num2.Text = "Num 2";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(122, 104);
            Result.Name = "Result";
            Result.Size = new Size(39, 15);
            Result.TabIndex = 2;
            Result.Text = "Result";
            // 
            // nNum1
            // 
            nNum1.Location = new Point(182, 43);
            nNum1.Name = "nNum1";
            nNum1.Size = new Size(100, 23);
            nNum1.TabIndex = 3;
            // 
            // rResult
            // 
            rResult.Location = new Point(182, 101);
            rResult.Name = "rResult";
            rResult.Size = new Size(100, 23);
            rResult.TabIndex = 4;
            // 
            // nNum2
            // 
            nNum2.Location = new Point(182, 72);
            nNum2.Name = "nNum2";
            nNum2.Size = new Size(100, 23);
            nNum2.TabIndex = 5;
            // 
            // result1
            // 
            result1.Location = new Point(299, 41);
            result1.Name = "result1";
            result1.Size = new Size(75, 23);
            result1.TabIndex = 6;
            result1.Text = "+";
            result1.UseVisualStyleBackColor = true;
            result1.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(299, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(389, 72);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "/";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(389, 41);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(299, 104);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(result1);
            Controls.Add(nNum2);
            Controls.Add(rResult);
            Controls.Add(nNum1);
            Controls.Add(Result);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Num1;
        private Label Num2;
        private Label Result;
        private MaskedTextBox nNum1;
        private MaskedTextBox rResult;
        private MaskedTextBox nNum2;
        private Button result1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
