namespace LabActivity4_Valerio_Form
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
            this.txtbx_snum = new System.Windows.Forms.TextBox();
            this.txt_snum = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.txt_ans = new System.Windows.Forms.Label();
            this.txtbx_ans = new System.Windows.Forms.TextBox();
            this.txt_bck = new System.Windows.Forms.Button();
            this.btn_rem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_fnum
            // 
            this.txt_fnum.AutoSize = true;
            this.txt_fnum.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fnum.Location = new System.Drawing.Point(19, 21);
            this.txt_fnum.Name = "txt_fnum";
            this.txt_fnum.Size = new System.Drawing.Size(79, 15);
            this.txt_fnum.TabIndex = 0;
            this.txt_fnum.Text = "First Number";
            // 
            // txtbx_fnum
            // 
            this.txtbx_fnum.Location = new System.Drawing.Point(104, 19);
            this.txtbx_fnum.Name = "txtbx_fnum";
            this.txtbx_fnum.Size = new System.Drawing.Size(130, 20);
            this.txtbx_fnum.TabIndex = 1;
            // 
            // txtbx_snum
            // 
            this.txtbx_snum.Location = new System.Drawing.Point(104, 48);
            this.txtbx_snum.Name = "txtbx_snum";
            this.txtbx_snum.Size = new System.Drawing.Size(130, 20);
            this.txtbx_snum.TabIndex = 3;
            // 
            // txt_snum
            // 
            this.txt_snum.AutoSize = true;
            this.txt_snum.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_snum.Location = new System.Drawing.Point(9, 50);
            this.txt_snum.Name = "txt_snum";
            this.txt_snum.Size = new System.Drawing.Size(89, 15);
            this.txt_snum.TabIndex = 2;
            this.txt_snum.Text = "Second Number";
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.Khaki;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(44, 84);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(54, 45);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Khaki;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(166, 84);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(56, 45);
            this.btn_min.TabIndex = 5;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.Khaki;
            this.btn_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mul.Location = new System.Drawing.Point(44, 135);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(54, 44);
            this.btn_mul.TabIndex = 6;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.Khaki;
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(166, 135);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(56, 42);
            this.btn_div.TabIndex = 7;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // txt_ans
            // 
            this.txt_ans.AutoSize = true;
            this.txt_ans.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ans.Location = new System.Drawing.Point(18, 223);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(56, 18);
            this.txt_ans.TabIndex = 8;
            this.txt_ans.Text = "Answer";
            this.txt_ans.Click += new System.EventHandler(this.txt_ans_Click);
            // 
            // txtbx_ans
            // 
            this.txtbx_ans.Location = new System.Drawing.Point(80, 223);
            this.txtbx_ans.Name = "txtbx_ans";
            this.txtbx_ans.Size = new System.Drawing.Size(98, 20);
            this.txtbx_ans.TabIndex = 9;
            this.txtbx_ans.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_bck
            // 
            this.txt_bck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_bck.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bck.Location = new System.Drawing.Point(199, 223);
            this.txt_bck.Name = "txt_bck";
            this.txt_bck.Size = new System.Drawing.Size(73, 26);
            this.txt_bck.TabIndex = 10;
            this.txt_bck.Text = "Back";
            this.txt_bck.UseVisualStyleBackColor = false;
            this.txt_bck.Click += new System.EventHandler(this.txt_bck_Click);
            // 
            // btn_rem
            // 
            this.btn_rem.BackColor = System.Drawing.Color.Khaki;
            this.btn_rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rem.Location = new System.Drawing.Point(104, 163);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(56, 42);
            this.btn_rem.TabIndex = 11;
            this.btn_rem.Text = "%";
            this.btn_rem.UseVisualStyleBackColor = false;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.txt_bck);
            this.Controls.Add(this.txtbx_ans);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.txtbx_snum);
            this.Controls.Add(this.txt_snum);
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
        private System.Windows.Forms.TextBox txtbx_snum;
        private System.Windows.Forms.Label txt_snum;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Label txt_ans;
        private System.Windows.Forms.TextBox txtbx_ans;
        private System.Windows.Forms.Button txt_bck;
        private System.Windows.Forms.Button btn_rem;
    }
}