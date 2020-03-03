namespace WindowsFormsApp1_Velasco
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Ans = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_quo = new System.Windows.Forms.Button();
            this.btn_diff = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtBox_Snum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_fnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Answer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBox_Ans
            // 
            this.txtBox_Ans.Location = new System.Drawing.Point(100, 201);
            this.txtBox_Ans.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Ans.Name = "txtBox_Ans";
            this.txtBox_Ans.Size = new System.Drawing.Size(67, 20);
            this.txtBox_Ans.TabIndex = 32;
            this.txtBox_Ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Ans.TextChanged += new System.EventHandler(this.txtBox_Ans_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Yellow;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(177, 192);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(57, 26);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_quo
            // 
            this.btn_quo.BackColor = System.Drawing.Color.Yellow;
            this.btn_quo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quo.Location = new System.Drawing.Point(177, 152);
            this.btn_quo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quo.Name = "btn_quo";
            this.btn_quo.Size = new System.Drawing.Size(57, 29);
            this.btn_quo.TabIndex = 30;
            this.btn_quo.Text = "/";
            this.btn_quo.UseVisualStyleBackColor = false;
            this.btn_quo.Click += new System.EventHandler(this.btn_quo_Click);
            // 
            // btn_diff
            // 
            this.btn_diff.BackColor = System.Drawing.Color.Yellow;
            this.btn_diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diff.Location = new System.Drawing.Point(177, 103);
            this.btn_diff.Margin = new System.Windows.Forms.Padding(2);
            this.btn_diff.Name = "btn_diff";
            this.btn_diff.Size = new System.Drawing.Size(57, 29);
            this.btn_diff.TabIndex = 29;
            this.btn_diff.Text = "-";
            this.btn_diff.UseVisualStyleBackColor = false;
            this.btn_diff.Click += new System.EventHandler(this.btn_diff_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.BackColor = System.Drawing.Color.Yellow;
            this.btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.Location = new System.Drawing.Point(41, 152);
            this.btn_prod.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(57, 29);
            this.btn_prod.TabIndex = 28;
            this.btn_prod.Text = "*";
            this.btn_prod.UseVisualStyleBackColor = false;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Yellow;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(41, 103);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(57, 29);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtBox_Snum
            // 
            this.txtBox_Snum.Location = new System.Drawing.Point(138, 69);
            this.txtBox_Snum.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Snum.Name = "txtBox_Snum";
            this.txtBox_Snum.Size = new System.Drawing.Size(120, 20);
            this.txtBox_Snum.TabIndex = 26;
            this.txtBox_Snum.TextChanged += new System.EventHandler(this.txtBox_Snum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Second Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBox_fnum
            // 
            this.txtBox_fnum.Location = new System.Drawing.Point(138, 39);
            this.txtBox_fnum.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_fnum.Name = "txtBox_fnum";
            this.txtBox_fnum.Size = new System.Drawing.Size(120, 20);
            this.txtBox_fnum.TabIndex = 24;
            this.txtBox_fnum.TextChanged += new System.EventHandler(this.txtBox_fnum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Ans;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_quo;
        private System.Windows.Forms.Button btn_diff;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtBox_Snum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_fnum;
        private System.Windows.Forms.Label label1;
    }
}