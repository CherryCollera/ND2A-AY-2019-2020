namespace GreetMe
{
    partial class Form2
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
            this.txt_fname = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.Label();
            this.txtbx_fname = new System.Windows.Forms.TextBox();
            this.txtbx_lname = new System.Windows.Forms.TextBox();
            this.btn_getMessage = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.AutoSize = true;
            this.txt_fname.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(17, 46);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(85, 18);
            this.txt_fname.TabIndex = 0;
            this.txt_fname.Text = "Firstname";
            // 
            // txt_lname
            // 
            this.txt_lname.AutoSize = true;
            this.txt_lname.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(17, 78);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(82, 18);
            this.txt_lname.TabIndex = 1;
            this.txt_lname.Text = "Lastname";
            this.txt_lname.Click += new System.EventHandler(this.txt_lname_Click);
            // 
            // txtbx_fname
            // 
            this.txtbx_fname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbx_fname.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fname.Location = new System.Drawing.Point(108, 44);
            this.txtbx_fname.Name = "txtbx_fname";
            this.txtbx_fname.Size = new System.Drawing.Size(140, 25);
            this.txtbx_fname.TabIndex = 2;
            // 
            // txtbx_lname
            // 
            this.txtbx_lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbx_lname.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lname.Location = new System.Drawing.Point(108, 75);
            this.txtbx_lname.Name = "txtbx_lname";
            this.txtbx_lname.Size = new System.Drawing.Size(140, 25);
            this.txtbx_lname.TabIndex = 3;
            // 
            // btn_getMessage
            // 
            this.btn_getMessage.BackColor = System.Drawing.Color.Black;
            this.btn_getMessage.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getMessage.ForeColor = System.Drawing.Color.Yellow;
            this.btn_getMessage.Location = new System.Drawing.Point(88, 137);
            this.btn_getMessage.Name = "btn_getMessage";
            this.btn_getMessage.Size = new System.Drawing.Size(107, 40);
            this.btn_getMessage.TabIndex = 4;
            this.btn_getMessage.Text = "Get Message";
            this.btn_getMessage.UseVisualStyleBackColor = false;
            this.btn_getMessage.Click += new System.EventHandler(this.btn_getMessage_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Maroon;
            this.btn_hide.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.Location = new System.Drawing.Point(204, 207);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(59, 23);
            this.btn_hide.TabIndex = 5;
            this.btn_hide.Text = "HIDE";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(27, 209);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(71, 20);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_getMessage);
            this.Controls.Add(this.txtbx_lname);
            this.Controls.Add(this.txtbx_fname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_fname;
        private System.Windows.Forms.Label txt_lname;
        private System.Windows.Forms.TextBox txtbx_fname;
        private System.Windows.Forms.TextBox txtbx_lname;
        private System.Windows.Forms.Button btn_getMessage;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_back;
    }
}