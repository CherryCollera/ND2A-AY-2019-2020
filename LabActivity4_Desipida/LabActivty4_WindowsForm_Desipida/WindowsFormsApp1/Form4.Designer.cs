namespace WindowsFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Remainder = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Snum = new System.Windows.Forms.TextBox();
            this.Fnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(179, 250);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 37);
            this.Back.TabIndex = 35;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(97, 257);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(66, 22);
            this.Ans.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Answer:";
            // 
            // Remainder
            // 
            this.Remainder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Remainder.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remainder.Location = new System.Drawing.Point(110, 202);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(53, 38);
            this.Remainder.TabIndex = 32;
            this.Remainder.Text = "%";
            this.Remainder.UseVisualStyleBackColor = false;
            this.Remainder.Click += new System.EventHandler(this.Remainder_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Divide.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(164, 157);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(55, 39);
            this.Divide.TabIndex = 31;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Multiply.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(54, 157);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(56, 39);
            this.Multiply.TabIndex = 30;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Subtract.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(164, 106);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(55, 45);
            this.Subtract.TabIndex = 29;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Add.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(54, 106);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(56, 45);
            this.Add.TabIndex = 28;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Snum
            // 
            this.Snum.Location = new System.Drawing.Point(153, 67);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(66, 22);
            this.Snum.TabIndex = 27;
            // 
            // Fnum
            // 
            this.Fnum.Location = new System.Drawing.Point(153, 24);
            this.Fnum.Name = "Fnum";
            this.Fnum.Size = new System.Drawing.Size(66, 22);
            this.Fnum.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Second Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Number:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(268, 308);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Remainder);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Snum);
            this.Controls.Add(this.Fnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Remainder;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Snum;
        private System.Windows.Forms.TextBox Fnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}