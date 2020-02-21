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
            this.lbl_fnumber = new System.Windows.Forms.Label();
            this.lbl_Snumber = new System.Windows.Forms.Label();
            this.txtbox_Fnumber = new System.Windows.Forms.TextBox();
            this.txtbox_Snumber = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_times = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_remainder = new System.Windows.Forms.Button();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txtbox_Answer = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_fnumber
            // 
            this.lbl_fnumber.AutoSize = true;
            this.lbl_fnumber.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fnumber.Location = new System.Drawing.Point(48, 15);
            this.lbl_fnumber.Name = "lbl_fnumber";
            this.lbl_fnumber.Size = new System.Drawing.Size(83, 17);
            this.lbl_fnumber.TabIndex = 0;
            this.lbl_fnumber.Text = "First Number";
            // 
            // lbl_Snumber
            // 
            this.lbl_Snumber.AutoSize = true;
            this.lbl_Snumber.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Snumber.Location = new System.Drawing.Point(30, 46);
            this.lbl_Snumber.Name = "lbl_Snumber";
            this.lbl_Snumber.Size = new System.Drawing.Size(93, 17);
            this.lbl_Snumber.TabIndex = 1;
            this.lbl_Snumber.Text = "Second Number";
            // 
            // txtbox_Fnumber
            // 
            this.txtbox_Fnumber.Location = new System.Drawing.Point(131, 12);
            this.txtbox_Fnumber.Name = "txtbox_Fnumber";
            this.txtbox_Fnumber.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Fnumber.TabIndex = 2;
            // 
            // txtbox_Snumber
            // 
            this.txtbox_Snumber.Location = new System.Drawing.Point(131, 43);
            this.txtbox_Snumber.Name = "txtbox_Snumber";
            this.txtbox_Snumber.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Snumber.TabIndex = 3;
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_plus.ForeColor = System.Drawing.Color.Black;
            this.btn_plus.Location = new System.Drawing.Point(51, 93);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_minus.Location = new System.Drawing.Point(176, 93);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 23);
            this.btn_minus.TabIndex = 5;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_times
            // 
            this.btn_times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_times.Location = new System.Drawing.Point(51, 132);
            this.btn_times.Name = "btn_times";
            this.btn_times.Size = new System.Drawing.Size(75, 23);
            this.btn_times.TabIndex = 6;
            this.btn_times.Text = "*";
            this.btn_times.UseVisualStyleBackColor = false;
            this.btn_times.Click += new System.EventHandler(this.btn_times_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_divide.Location = new System.Drawing.Point(176, 132);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 7;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_remainder
            // 
            this.btn_remainder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_remainder.Location = new System.Drawing.Point(113, 161);
            this.btn_remainder.Name = "btn_remainder";
            this.btn_remainder.Size = new System.Drawing.Size(75, 23);
            this.btn_remainder.TabIndex = 8;
            this.btn_remainder.Text = "%";
            this.btn_remainder.UseVisualStyleBackColor = false;
            this.btn_remainder.Click += new System.EventHandler(this.btn_remainder_Click);
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.Location = new System.Drawing.Point(22, 213);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(54, 17);
            this.lbl_Answer.TabIndex = 9;
            this.lbl_Answer.Text = "Answer:";
            // 
            // txtbox_Answer
            // 
            this.txtbox_Answer.Location = new System.Drawing.Point(82, 213);
            this.txtbox_Answer.Name = "txtbox_Answer";
            this.txtbox_Answer.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Answer.TabIndex = 10;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Orange;
            this.btn_Back.Font = new System.Drawing.Font("Bradley Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Green;
            this.btn_Back.Location = new System.Drawing.Point(197, 213);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txtbox_Answer);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.btn_remainder);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_times);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.txtbox_Snumber);
            this.Controls.Add(this.txtbox_Fnumber);
            this.Controls.Add(this.lbl_Snumber);
            this.Controls.Add(this.lbl_fnumber);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fnumber;
        private System.Windows.Forms.Label lbl_Snumber;
        private System.Windows.Forms.TextBox txtbox_Fnumber;
        private System.Windows.Forms.TextBox txtbox_Snumber;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_times;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_remainder;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.TextBox txtbox_Answer;
        private System.Windows.Forms.Button btn_Back;
    }
}