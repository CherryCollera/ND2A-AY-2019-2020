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
            this.lbl_SNum = new System.Windows.Forms.Label();
            this.lbl_Fnum = new System.Windows.Forms.Label();
            this.txtBox_SNum = new System.Windows.Forms.TextBox();
            this.txtBox_Fnum = new System.Windows.Forms.TextBox();
            this.bttn_Sum = new System.Windows.Forms.Button();
            this.bttn_Difference = new System.Windows.Forms.Button();
            this.bttn_Product = new System.Windows.Forms.Button();
            this.bttn_Quotient = new System.Windows.Forms.Button();
            this.bttn_Rem = new System.Windows.Forms.Button();
            this.lbl_Ans = new System.Windows.Forms.Label();
            this.txtBox_Answer = new System.Windows.Forms.TextBox();
            this.bttn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SNum
            // 
            this.lbl_SNum.AutoSize = true;
            this.lbl_SNum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SNum.Location = new System.Drawing.Point(5, 64);
            this.lbl_SNum.Name = "lbl_SNum";
            this.lbl_SNum.Size = new System.Drawing.Size(142, 18);
            this.lbl_SNum.TabIndex = 15;
            this.lbl_SNum.Text = "Enter Second Number:";
            // 
            // lbl_Fnum
            // 
            this.lbl_Fnum.AutoSize = true;
            this.lbl_Fnum.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fnum.Location = new System.Drawing.Point(5, 36);
            this.lbl_Fnum.Name = "lbl_Fnum";
            this.lbl_Fnum.Size = new System.Drawing.Size(118, 17);
            this.lbl_Fnum.TabIndex = 14;
            this.lbl_Fnum.Text = "Enter First Number:";
            // 
            // txtBox_SNum
            // 
            this.txtBox_SNum.Location = new System.Drawing.Point(150, 62);
            this.txtBox_SNum.Name = "txtBox_SNum";
            this.txtBox_SNum.Size = new System.Drawing.Size(119, 20);
            this.txtBox_SNum.TabIndex = 13;
            // 
            // txtBox_Fnum
            // 
            this.txtBox_Fnum.Location = new System.Drawing.Point(150, 35);
            this.txtBox_Fnum.Name = "txtBox_Fnum";
            this.txtBox_Fnum.Size = new System.Drawing.Size(119, 20);
            this.txtBox_Fnum.TabIndex = 12;
            // 
            // bttn_Sum
            // 
            this.bttn_Sum.BackColor = System.Drawing.Color.Gold;
            this.bttn_Sum.Location = new System.Drawing.Point(30, 107);
            this.bttn_Sum.Name = "bttn_Sum";
            this.bttn_Sum.Size = new System.Drawing.Size(75, 23);
            this.bttn_Sum.TabIndex = 16;
            this.bttn_Sum.Text = "+";
            this.bttn_Sum.UseVisualStyleBackColor = false;
            this.bttn_Sum.Click += new System.EventHandler(this.bttn_Sum_Click);
            // 
            // bttn_Difference
            // 
            this.bttn_Difference.BackColor = System.Drawing.Color.Gold;
            this.bttn_Difference.Location = new System.Drawing.Point(161, 107);
            this.bttn_Difference.Name = "bttn_Difference";
            this.bttn_Difference.Size = new System.Drawing.Size(75, 23);
            this.bttn_Difference.TabIndex = 17;
            this.bttn_Difference.Text = "-";
            this.bttn_Difference.UseVisualStyleBackColor = false;
            this.bttn_Difference.Click += new System.EventHandler(this.bttn_Difference_Click);
            // 
            // bttn_Product
            // 
            this.bttn_Product.BackColor = System.Drawing.Color.Gold;
            this.bttn_Product.Location = new System.Drawing.Point(30, 149);
            this.bttn_Product.Name = "bttn_Product";
            this.bttn_Product.Size = new System.Drawing.Size(75, 23);
            this.bttn_Product.TabIndex = 18;
            this.bttn_Product.Text = "*";
            this.bttn_Product.UseVisualStyleBackColor = false;
            this.bttn_Product.Click += new System.EventHandler(this.bttn_Product_Click);
            // 
            // bttn_Quotient
            // 
            this.bttn_Quotient.BackColor = System.Drawing.Color.Gold;
            this.bttn_Quotient.Location = new System.Drawing.Point(161, 149);
            this.bttn_Quotient.Name = "bttn_Quotient";
            this.bttn_Quotient.Size = new System.Drawing.Size(75, 23);
            this.bttn_Quotient.TabIndex = 19;
            this.bttn_Quotient.Text = "/";
            this.bttn_Quotient.UseVisualStyleBackColor = false;
            this.bttn_Quotient.Click += new System.EventHandler(this.bttn_Quotient_Click);
            // 
            // bttn_Rem
            // 
            this.bttn_Rem.BackColor = System.Drawing.Color.Gold;
            this.bttn_Rem.Location = new System.Drawing.Point(93, 188);
            this.bttn_Rem.Name = "bttn_Rem";
            this.bttn_Rem.Size = new System.Drawing.Size(75, 23);
            this.bttn_Rem.TabIndex = 20;
            this.bttn_Rem.Text = "%";
            this.bttn_Rem.UseVisualStyleBackColor = false;
            this.bttn_Rem.Click += new System.EventHandler(this.bttn_Rem_Click);
            // 
            // lbl_Ans
            // 
            this.lbl_Ans.AutoSize = true;
            this.lbl_Ans.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ans.Location = new System.Drawing.Point(26, 226);
            this.lbl_Ans.Name = "lbl_Ans";
            this.lbl_Ans.Size = new System.Drawing.Size(82, 26);
            this.lbl_Ans.TabIndex = 22;
            this.lbl_Ans.Text = "Answer:";
            // 
            // txtBox_Answer
            // 
            this.txtBox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Answer.Location = new System.Drawing.Point(133, 226);
            this.txtBox_Answer.Name = "txtBox_Answer";
            this.txtBox_Answer.Size = new System.Drawing.Size(119, 22);
            this.txtBox_Answer.TabIndex = 21;
            // 
            // bttn_Back
            // 
            this.bttn_Back.Location = new System.Drawing.Point(93, 275);
            this.bttn_Back.Name = "bttn_Back";
            this.bttn_Back.Size = new System.Drawing.Size(75, 23);
            this.bttn_Back.TabIndex = 23;
            this.bttn_Back.Text = "Back";
            this.bttn_Back.UseVisualStyleBackColor = true;
            this.bttn_Back.Click += new System.EventHandler(this.bttn_Back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 305);
            this.Controls.Add(this.bttn_Back);
            this.Controls.Add(this.lbl_Ans);
            this.Controls.Add(this.txtBox_Answer);
            this.Controls.Add(this.bttn_Rem);
            this.Controls.Add(this.bttn_Quotient);
            this.Controls.Add(this.bttn_Product);
            this.Controls.Add(this.bttn_Difference);
            this.Controls.Add(this.bttn_Sum);
            this.Controls.Add(this.lbl_SNum);
            this.Controls.Add(this.lbl_Fnum);
            this.Controls.Add(this.txtBox_SNum);
            this.Controls.Add(this.txtBox_Fnum);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SNum;
        private System.Windows.Forms.Label lbl_Fnum;
        private System.Windows.Forms.TextBox txtBox_SNum;
        private System.Windows.Forms.TextBox txtBox_Fnum;
        private System.Windows.Forms.Button bttn_Sum;
        private System.Windows.Forms.Button bttn_Difference;
        private System.Windows.Forms.Button bttn_Product;
        private System.Windows.Forms.Button bttn_Quotient;
        private System.Windows.Forms.Button bttn_Rem;
        private System.Windows.Forms.Label lbl_Ans;
        private System.Windows.Forms.TextBox txtBox_Answer;
        private System.Windows.Forms.Button bttn_Back;
    }
}