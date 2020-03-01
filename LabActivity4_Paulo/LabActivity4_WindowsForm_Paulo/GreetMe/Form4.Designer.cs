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
            this.Label_Snum = new System.Windows.Forms.Label();
            this.Txtbox_Snum = new System.Windows.Forms.TextBox();
            this.Label_Fnum = new System.Windows.Forms.Label();
            this.Txtbox_Fnum = new System.Windows.Forms.TextBox();
            this.Btn_plus = new System.Windows.Forms.Button();
            this.Btn_minus = new System.Windows.Forms.Button();
            this.Btn_times = new System.Windows.Forms.Button();
            this.Btn_divide = new System.Windows.Forms.Button();
            this.Btn_remainder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.Btn_bck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Snum
            // 
            this.Label_Snum.AutoSize = true;
            this.Label_Snum.Location = new System.Drawing.Point(9, 50);
            this.Label_Snum.Name = "Label_Snum";
            this.Label_Snum.Size = new System.Drawing.Size(87, 13);
            this.Label_Snum.TabIndex = 7;
            this.Label_Snum.Text = "Second Number:";
            this.Label_Snum.Click += new System.EventHandler(this.Label_Lname_Click);
            // 
            // Txtbox_Snum
            // 
            this.Txtbox_Snum.Location = new System.Drawing.Point(102, 50);
            this.Txtbox_Snum.Name = "Txtbox_Snum";
            this.Txtbox_Snum.Size = new System.Drawing.Size(114, 20);
            this.Txtbox_Snum.TabIndex = 6;
            // 
            // Label_Fnum
            // 
            this.Label_Fnum.AutoSize = true;
            this.Label_Fnum.Location = new System.Drawing.Point(27, 15);
            this.Label_Fnum.Name = "Label_Fnum";
            this.Label_Fnum.Size = new System.Drawing.Size(69, 13);
            this.Label_Fnum.TabIndex = 5;
            this.Label_Fnum.Text = "First Number:";
            // 
            // Txtbox_Fnum
            // 
            this.Txtbox_Fnum.Location = new System.Drawing.Point(102, 12);
            this.Txtbox_Fnum.Name = "Txtbox_Fnum";
            this.Txtbox_Fnum.Size = new System.Drawing.Size(114, 20);
            this.Txtbox_Fnum.TabIndex = 4;
            this.Txtbox_Fnum.TextChanged += new System.EventHandler(this.Txtbox_Fname_TextChanged);
            // 
            // Btn_plus
            // 
            this.Btn_plus.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_plus.Location = new System.Drawing.Point(14, 98);
            this.Btn_plus.Name = "Btn_plus";
            this.Btn_plus.Size = new System.Drawing.Size(82, 54);
            this.Btn_plus.TabIndex = 8;
            this.Btn_plus.Text = "+";
            this.Btn_plus.UseVisualStyleBackColor = true;
            this.Btn_plus.Click += new System.EventHandler(this.Btn_plus_Click);
            // 
            // Btn_minus
            // 
            this.Btn_minus.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_minus.Location = new System.Drawing.Point(102, 98);
            this.Btn_minus.Name = "Btn_minus";
            this.Btn_minus.Size = new System.Drawing.Size(82, 54);
            this.Btn_minus.TabIndex = 9;
            this.Btn_minus.Text = "-";
            this.Btn_minus.UseVisualStyleBackColor = true;
            this.Btn_minus.Click += new System.EventHandler(this.Btn_minus_Click);
            // 
            // Btn_times
            // 
            this.Btn_times.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_times.Location = new System.Drawing.Point(14, 158);
            this.Btn_times.Name = "Btn_times";
            this.Btn_times.Size = new System.Drawing.Size(82, 54);
            this.Btn_times.TabIndex = 10;
            this.Btn_times.Text = "*";
            this.Btn_times.UseVisualStyleBackColor = true;
            this.Btn_times.Click += new System.EventHandler(this.Btn_times_Click);
            // 
            // Btn_divide
            // 
            this.Btn_divide.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_divide.Location = new System.Drawing.Point(102, 158);
            this.Btn_divide.Name = "Btn_divide";
            this.Btn_divide.Size = new System.Drawing.Size(82, 54);
            this.Btn_divide.TabIndex = 11;
            this.Btn_divide.Text = "/";
            this.Btn_divide.UseVisualStyleBackColor = true;
            this.Btn_divide.Click += new System.EventHandler(this.Btn_divide_Click);
            // 
            // Btn_remainder
            // 
            this.Btn_remainder.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_remainder.Location = new System.Drawing.Point(190, 129);
            this.Btn_remainder.Name = "Btn_remainder";
            this.Btn_remainder.Size = new System.Drawing.Size(82, 54);
            this.Btn_remainder.TabIndex = 12;
            this.Btn_remainder.Text = "%";
            this.Btn_remainder.UseVisualStyleBackColor = true;
            this.Btn_remainder.Click += new System.EventHandler(this.Btn_remainder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Answer:";
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Location = new System.Drawing.Point(91, 221);
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.Size = new System.Drawing.Size(77, 20);
            this.TxtAnswer.TabIndex = 14;
            // 
            // Btn_bck
            // 
            this.Btn_bck.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Btn_bck.Location = new System.Drawing.Point(205, 210);
            this.Btn_bck.Name = "Btn_bck";
            this.Btn_bck.Size = new System.Drawing.Size(67, 39);
            this.Btn_bck.TabIndex = 15;
            this.Btn_bck.Text = "Back";
            this.Btn_bck.UseVisualStyleBackColor = true;
            this.Btn_bck.Click += new System.EventHandler(this.Btn_bck_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Btn_bck);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_remainder);
            this.Controls.Add(this.Btn_divide);
            this.Controls.Add(this.Btn_times);
            this.Controls.Add(this.Btn_minus);
            this.Controls.Add(this.Btn_plus);
            this.Controls.Add(this.Label_Snum);
            this.Controls.Add(this.Txtbox_Snum);
            this.Controls.Add(this.Label_Fnum);
            this.Controls.Add(this.Txtbox_Fnum);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Snum;
        private System.Windows.Forms.TextBox Txtbox_Snum;
        private System.Windows.Forms.Label Label_Fnum;
        private System.Windows.Forms.TextBox Txtbox_Fnum;
        private System.Windows.Forms.Button Btn_plus;
        private System.Windows.Forms.Button Btn_minus;
        private System.Windows.Forms.Button Btn_times;
        private System.Windows.Forms.Button Btn_divide;
        private System.Windows.Forms.Button Btn_remainder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.Button Btn_bck;
    }
}