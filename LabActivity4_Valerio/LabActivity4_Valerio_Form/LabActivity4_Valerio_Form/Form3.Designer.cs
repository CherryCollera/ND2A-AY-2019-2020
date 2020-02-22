namespace LabActivity4_Valerio_Form
{
    partial class Form3
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
            this.txtbx_fname = new System.Windows.Forms.TextBox();
            this.txtbx_lname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.Label();
            this.btn_getMyProfile = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_myprofile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.AutoSize = true;
            this.txt_fname.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(20, 67);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(72, 17);
            this.txt_fname.TabIndex = 0;
            this.txt_fname.Text = "FirstName";
            // 
            // txtbx_fname
            // 
            this.txtbx_fname.Location = new System.Drawing.Point(95, 67);
            this.txtbx_fname.Name = "txtbx_fname";
            this.txtbx_fname.Size = new System.Drawing.Size(161, 20);
            this.txtbx_fname.TabIndex = 1;
            // 
            // txtbx_lname
            // 
            this.txtbx_lname.Location = new System.Drawing.Point(95, 93);
            this.txtbx_lname.Name = "txtbx_lname";
            this.txtbx_lname.Size = new System.Drawing.Size(161, 20);
            this.txtbx_lname.TabIndex = 3;
            this.txtbx_lname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_lname
            // 
            this.txt_lname.AutoSize = true;
            this.txt_lname.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(23, 93);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(69, 17);
            this.txt_lname.TabIndex = 2;
            this.txt_lname.Text = "LastName";
            this.txt_lname.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_getMyProfile
            // 
            this.btn_getMyProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_getMyProfile.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getMyProfile.Location = new System.Drawing.Point(10, 162);
            this.btn_getMyProfile.Name = "btn_getMyProfile";
            this.btn_getMyProfile.Size = new System.Drawing.Size(88, 46);
            this.btn_getMyProfile.TabIndex = 4;
            this.btn_getMyProfile.Text = "Get My Profile";
            this.btn_getMyProfile.UseVisualStyleBackColor = false;
            this.btn_getMyProfile.Click += new System.EventHandler(this.btn_getMyProfile_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_hide.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.Location = new System.Drawing.Point(104, 162);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(81, 46);
            this.btn_hide.TabIndex = 5;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_back.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(191, 162);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(79, 46);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_myprofile
            // 
            this.lbl_myprofile.AutoSize = true;
            this.lbl_myprofile.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_myprofile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_myprofile.Location = new System.Drawing.Point(80, 19);
            this.lbl_myprofile.Name = "lbl_myprofile";
            this.lbl_myprofile.Size = new System.Drawing.Size(120, 23);
            this.lbl_myprofile.TabIndex = 7;
            this.lbl_myprofile.Text = "MY PROFILE";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_myprofile);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_getMyProfile);
            this.Controls.Add(this.txtbx_lname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txtbx_fname);
            this.Controls.Add(this.txt_fname);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_fname;
        private System.Windows.Forms.TextBox txtbx_fname;
        private System.Windows.Forms.TextBox txtbx_lname;
        private System.Windows.Forms.Label txt_lname;
        private System.Windows.Forms.Button btn_getMyProfile;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_myprofile;
    }
}