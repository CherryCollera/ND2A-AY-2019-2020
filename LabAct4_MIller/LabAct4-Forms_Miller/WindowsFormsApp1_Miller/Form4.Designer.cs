namespace WindowsFormsApp1_Miller
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
            this.txtBox_Snum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_fnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_diff = new System.Windows.Forms.Button();
            this.btn_quo = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtBox_Ans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Snum
            // 
            this.txtBox_Snum.Location = new System.Drawing.Point(171, 85);
            this.txtBox_Snum.Name = "txtBox_Snum";
            this.txtBox_Snum.Size = new System.Drawing.Size(178, 26);
            this.txtBox_Snum.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Second Number:";
            // 
            // txtBox_fnum
            // 
            this.txtBox_fnum.Location = new System.Drawing.Point(171, 38);
            this.txtBox_fnum.Name = "txtBox_fnum";
            this.txtBox_fnum.Size = new System.Drawing.Size(178, 26);
            this.txtBox_fnum.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Number:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Yellow;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(26, 137);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 45);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.BackColor = System.Drawing.Color.Yellow;
            this.btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.Location = new System.Drawing.Point(26, 212);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(86, 45);
            this.btn_prod.TabIndex = 17;
            this.btn_prod.Text = "*";
            this.btn_prod.UseVisualStyleBackColor = false;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_diff
            // 
            this.btn_diff.BackColor = System.Drawing.Color.Yellow;
            this.btn_diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diff.Location = new System.Drawing.Point(230, 137);
            this.btn_diff.Name = "btn_diff";
            this.btn_diff.Size = new System.Drawing.Size(86, 45);
            this.btn_diff.TabIndex = 18;
            this.btn_diff.Text = "-";
            this.btn_diff.UseVisualStyleBackColor = false;
            this.btn_diff.Click += new System.EventHandler(this.btn_diff_Click);
            // 
            // btn_quo
            // 
            this.btn_quo.BackColor = System.Drawing.Color.Yellow;
            this.btn_quo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quo.Location = new System.Drawing.Point(230, 212);
            this.btn_quo.Name = "btn_quo";
            this.btn_quo.Size = new System.Drawing.Size(86, 45);
            this.btn_quo.TabIndex = 19;
            this.btn_quo.Text = "/";
            this.btn_quo.UseVisualStyleBackColor = false;
            this.btn_quo.Click += new System.EventHandler(this.btn_quo_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Yellow;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(230, 274);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(86, 40);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtBox_Ans
            // 
            this.txtBox_Ans.Location = new System.Drawing.Point(114, 288);
            this.txtBox_Ans.Name = "txtBox_Ans";
            this.txtBox_Ans.Size = new System.Drawing.Size(98, 26);
            this.txtBox_Ans.TabIndex = 21;
            this.txtBox_Ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Ans.TextChanged += new System.EventHandler(this.txtBox_Ans_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Answer";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Ans);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_quo);
            this.Controls.Add(this.btn_diff);
            this.Controls.Add(this.btn_prod);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtBox_Snum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_fnum);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Snum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_fnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_diff;
        private System.Windows.Forms.Button btn_quo;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtBox_Ans;
        private System.Windows.Forms.Label label3;
    }
}