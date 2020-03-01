namespace GreetMe
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
            this.txtbx_Lname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.Label();
            this.btn_getMyProfile = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_myprofile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.AutoSize = true;
            this.txt_fname.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(44, 82);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(74, 15);
            this.txt_fname.TabIndex = 0;
            this.txt_fname.Text = "Firstname";
            // 
            // txtbx_fname
            // 
            this.txtbx_fname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbx_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fname.Location = new System.Drawing.Point(116, 79);
            this.txtbx_fname.Name = "txtbx_fname";
            this.txtbx_fname.Size = new System.Drawing.Size(146, 22);
            this.txtbx_fname.TabIndex = 1;
            // 
            // txtbx_Lname
            // 
            this.txtbx_Lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtbx_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Lname.Location = new System.Drawing.Point(116, 105);
            this.txtbx_Lname.Name = "txtbx_Lname";
            this.txtbx_Lname.Size = new System.Drawing.Size(146, 22);
            this.txtbx_Lname.TabIndex = 3;
            // 
            // txt_lname
            // 
            this.txt_lname.AutoSize = true;
            this.txt_lname.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(44, 108);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(71, 15);
            this.txt_lname.TabIndex = 2;
            this.txt_lname.Text = "Lastname";
            // 
            // btn_getMyProfile
            // 
            this.btn_getMyProfile.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getMyProfile.Location = new System.Drawing.Point(12, 173);
            this.btn_getMyProfile.Name = "btn_getMyProfile";
            this.btn_getMyProfile.Size = new System.Drawing.Size(111, 35);
            this.btn_getMyProfile.TabIndex = 4;
            this.btn_getMyProfile.Text = "Get My Profile";
            this.btn_getMyProfile.UseVisualStyleBackColor = true;
            this.btn_getMyProfile.Click += new System.EventHandler(this.btn_getMyProfile_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.Location = new System.Drawing.Point(139, 172);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(73, 36);
            this.btn_hide.TabIndex = 5;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(228, 172);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(64, 36);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_myprofile
            // 
            this.txt_myprofile.AutoSize = true;
            this.txt_myprofile.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_myprofile.Location = new System.Drawing.Point(104, 33);
            this.txt_myprofile.Name = "txt_myprofile";
            this.txt_myprofile.Size = new System.Drawing.Size(108, 18);
            this.txt_myprofile.TabIndex = 7;
            this.txt_myprofile.Text = "MY PROFILE";
            this.txt_myprofile.Click += new System.EventHandler(this.txt_myprofile_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.txt_myprofile);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_getMyProfile);
            this.Controls.Add(this.txtbx_Lname);
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
        private System.Windows.Forms.TextBox txtbx_Lname;
        private System.Windows.Forms.Label txt_lname;
        private System.Windows.Forms.Button btn_getMyProfile;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label txt_myprofile;
    }
}