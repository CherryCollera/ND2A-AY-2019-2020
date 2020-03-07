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
            this.txt_fnum = new System.Windows.Forms.Label();
            this.txtbx_fnum = new System.Windows.Forms.TextBox();
            this.txt_Secnum = new System.Windows.Forms.TextBox();
            this.txt_Snum = new System.Windows.Forms.Label();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Diff = new System.Windows.Forms.Button();
            this.btn_Prod = new System.Windows.Forms.Button();
            this.btn_Quotient = new System.Windows.Forms.Button();
            this.txt_Ans = new System.Windows.Forms.Label();
            this.txtbx_Ans = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_fnum
            // 
            this.txt_fnum.AutoSize = true;
            this.txt_fnum.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fnum.Location = new System.Drawing.Point(16, 36);
            this.txt_fnum.Name = "txt_fnum";
            this.txt_fnum.Size = new System.Drawing.Size(98, 15);
            this.txt_fnum.TabIndex = 0;
            this.txt_fnum.Text = "First Number:";
            // 
            // txtbx_fnum
            // 
            this.txtbx_fnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbx_fnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fnum.Location = new System.Drawing.Point(126, 31);
            this.txtbx_fnum.Name = "txtbx_fnum";
            this.txtbx_fnum.Size = new System.Drawing.Size(104, 22);
            this.txtbx_fnum.TabIndex = 1;
            // 
            // txt_Secnum
            // 
            this.txt_Secnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Secnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Secnum.Location = new System.Drawing.Point(126, 57);
            this.txt_Secnum.Name = "txt_Secnum";
            this.txt_Secnum.Size = new System.Drawing.Size(104, 22);
            this.txt_Secnum.TabIndex = 3;
            // 
            // txt_Snum
            // 
            this.txt_Snum.AutoSize = true;
            this.txt_Snum.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Snum.Location = new System.Drawing.Point(16, 62);
            this.txt_Snum.Name = "txt_Snum";
            this.txt_Snum.Size = new System.Drawing.Size(111, 15);
            this.txt_Snum.TabIndex = 2;
            this.txt_Snum.Text = "Second Number:";
            // 
            // btn_Sum
            // 
            this.btn_Sum.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sum.Location = new System.Drawing.Point(19, 114);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(80, 39);
            this.btn_Sum.TabIndex = 4;
            this.btn_Sum.Text = "+";
            this.btn_Sum.UseVisualStyleBackColor = false;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // btn_Diff
            // 
            this.btn_Diff.BackColor = System.Drawing.Color.Yellow;
            this.btn_Diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Diff.Location = new System.Drawing.Point(161, 114);
            this.btn_Diff.Name = "btn_Diff";
            this.btn_Diff.Size = new System.Drawing.Size(77, 39);
            this.btn_Diff.TabIndex = 5;
            this.btn_Diff.Text = "-";
            this.btn_Diff.UseVisualStyleBackColor = false;
            this.btn_Diff.Click += new System.EventHandler(this.btn_Diff_Click);
            // 
            // btn_Prod
            // 
            this.btn_Prod.BackColor = System.Drawing.Color.Yellow;
            this.btn_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prod.Location = new System.Drawing.Point(19, 159);
            this.btn_Prod.Name = "btn_Prod";
            this.btn_Prod.Size = new System.Drawing.Size(80, 35);
            this.btn_Prod.TabIndex = 6;
            this.btn_Prod.Text = "*";
            this.btn_Prod.UseVisualStyleBackColor = false;
            this.btn_Prod.Click += new System.EventHandler(this.btn_Prod_Click);
            // 
            // btn_Quotient
            // 
            this.btn_Quotient.BackColor = System.Drawing.Color.Yellow;
            this.btn_Quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quotient.Location = new System.Drawing.Point(161, 159);
            this.btn_Quotient.Name = "btn_Quotient";
            this.btn_Quotient.Size = new System.Drawing.Size(77, 35);
            this.btn_Quotient.TabIndex = 6;
            this.btn_Quotient.Text = "/";
            this.btn_Quotient.UseVisualStyleBackColor = false;
            this.btn_Quotient.Click += new System.EventHandler(this.btn_Quotient_Click);
            // 
            // txt_Ans
            // 
            this.txt_Ans.AutoSize = true;
            this.txt_Ans.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ans.Location = new System.Drawing.Point(16, 227);
            this.txt_Ans.Name = "txt_Ans";
            this.txt_Ans.Size = new System.Drawing.Size(60, 15);
            this.txt_Ans.TabIndex = 7;
            this.txt_Ans.Text = "Answer:";
            // 
            // txtbx_Ans
            // 
            this.txtbx_Ans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtbx_Ans.Location = new System.Drawing.Point(82, 225);
            this.txtbx_Ans.Name = "txtbx_Ans";
            this.txtbx_Ans.Size = new System.Drawing.Size(62, 20);
            this.txtbx_Ans.TabIndex = 8;
            this.txtbx_Ans.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Maroon;
            this.btn_back.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(178, 224);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(57, 26);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Mod
            // 
            this.btn_Mod.BackColor = System.Drawing.Color.Yellow;
            this.btn_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mod.Location = new System.Drawing.Point(110, 114);
            this.btn_Mod.Name = "btn_Mod";
            this.btn_Mod.Size = new System.Drawing.Size(45, 79);
            this.btn_Mod.TabIndex = 10;
            this.btn_Mod.Text = "%";
            this.btn_Mod.UseVisualStyleBackColor = false;
            this.btn_Mod.Click += new System.EventHandler(this.btn_Mod_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 261);
            this.Controls.Add(this.btn_Mod);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txtbx_Ans);
            this.Controls.Add(this.txt_Ans);
            this.Controls.Add(this.btn_Prod);
            this.Controls.Add(this.btn_Quotient);
            this.Controls.Add(this.btn_Diff);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.txt_Secnum);
            this.Controls.Add(this.txt_Snum);
            this.Controls.Add(this.txtbx_fnum);
            this.Controls.Add(this.txt_fnum);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_fnum;
        private System.Windows.Forms.TextBox txtbx_fnum;
        private System.Windows.Forms.TextBox txt_Secnum;
        private System.Windows.Forms.Label txt_Snum;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Diff;
        private System.Windows.Forms.Button btn_Prod;
        private System.Windows.Forms.Button btn_Quotient;
        private System.Windows.Forms.Label txt_Ans;
        private System.Windows.Forms.TextBox txtbx_Ans;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Mod;
    }
}