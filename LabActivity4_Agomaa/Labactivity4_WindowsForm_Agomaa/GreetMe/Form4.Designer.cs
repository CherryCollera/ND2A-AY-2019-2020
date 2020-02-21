namespace GreetMe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_firstnumber = new System.Windows.Forms.TextBox();
            this.txtbox_secondnumber = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_difference = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_answer = new System.Windows.Forms.TextBox();
            this.btn_remainder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtbox_firstnumber
            // 
            this.txtbox_firstnumber.Location = new System.Drawing.Point(108, 31);
            this.txtbox_firstnumber.Name = "txtbox_firstnumber";
            this.txtbox_firstnumber.Size = new System.Drawing.Size(131, 20);
            this.txtbox_firstnumber.TabIndex = 2;
            // 
            // txtbox_secondnumber
            // 
            this.txtbox_secondnumber.Location = new System.Drawing.Point(108, 59);
            this.txtbox_secondnumber.Name = "txtbox_secondnumber";
            this.txtbox_secondnumber.Size = new System.Drawing.Size(131, 20);
            this.txtbox_secondnumber.TabIndex = 3;
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.Yellow;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(25, 107);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(98, 29);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_difference
            // 
            this.btn_difference.BackColor = System.Drawing.Color.Yellow;
            this.btn_difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_difference.Location = new System.Drawing.Point(149, 107);
            this.btn_difference.Name = "btn_difference";
            this.btn_difference.Size = new System.Drawing.Size(106, 29);
            this.btn_difference.TabIndex = 5;
            this.btn_difference.Text = "-";
            this.btn_difference.UseVisualStyleBackColor = false;
            this.btn_difference.Click += new System.EventHandler(this.btn_difference_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.Color.Yellow;
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(25, 142);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(98, 34);
            this.btn_multiply.TabIndex = 6;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.Yellow;
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(149, 142);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(106, 34);
            this.btn_division.TabIndex = 7;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(180, 220);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Answer";
            // 
            // txtbox_answer
            // 
            this.txtbox_answer.Location = new System.Drawing.Point(72, 225);
            this.txtbox_answer.Name = "txtbox_answer";
            this.txtbox_answer.Size = new System.Drawing.Size(84, 20);
            this.txtbox_answer.TabIndex = 10;
            // 
            // btn_remainder
            // 
            this.btn_remainder.BackColor = System.Drawing.Color.Yellow;
            this.btn_remainder.Location = new System.Drawing.Point(93, 182);
            this.btn_remainder.Name = "btn_remainder";
            this.btn_remainder.Size = new System.Drawing.Size(75, 23);
            this.btn_remainder.TabIndex = 11;
            this.btn_remainder.Text = "%";
            this.btn_remainder.UseVisualStyleBackColor = false;
            this.btn_remainder.Click += new System.EventHandler(this.btn_remainder_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_remainder);
            this.Controls.Add(this.txtbox_answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_difference);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.txtbox_secondnumber);
            this.Controls.Add(this.txtbox_firstnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_firstnumber;
        private System.Windows.Forms.TextBox txtbox_secondnumber;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_difference;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_answer;
        private System.Windows.Forms.Button btn_remainder;
    }
}