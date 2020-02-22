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
            this.label_myprofile = new System.Windows.Forms.Label();
            this.Label_Lname = new System.Windows.Forms.Label();
            this.Txtbox_Lname = new System.Windows.Forms.TextBox();
            this.Label_Fname = new System.Windows.Forms.Label();
            this.Txtbox_Fname = new System.Windows.Forms.TextBox();
            this.Btn_Profile = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.Btn_bck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_myprofile
            // 
            this.label_myprofile.AutoSize = true;
            this.label_myprofile.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_myprofile.Location = new System.Drawing.Point(68, 9);
            this.label_myprofile.Name = "label_myprofile";
            this.label_myprofile.Size = new System.Drawing.Size(162, 43);
            this.label_myprofile.TabIndex = 0;
            this.label_myprofile.Text = "My Profile";
            // 
            // Label_Lname
            // 
            this.Label_Lname.AutoSize = true;
            this.Label_Lname.Location = new System.Drawing.Point(55, 119);
            this.Label_Lname.Name = "Label_Lname";
            this.Label_Lname.Size = new System.Drawing.Size(56, 13);
            this.Label_Lname.TabIndex = 7;
            this.Label_Lname.Text = "Lastname:";
            // 
            // Txtbox_Lname
            // 
            this.Txtbox_Lname.Location = new System.Drawing.Point(116, 119);
            this.Txtbox_Lname.Name = "Txtbox_Lname";
            this.Txtbox_Lname.Size = new System.Drawing.Size(114, 20);
            this.Txtbox_Lname.TabIndex = 6;
            // 
            // Label_Fname
            // 
            this.Label_Fname.AutoSize = true;
            this.Label_Fname.Location = new System.Drawing.Point(55, 74);
            this.Label_Fname.Name = "Label_Fname";
            this.Label_Fname.Size = new System.Drawing.Size(55, 13);
            this.Label_Fname.TabIndex = 5;
            this.Label_Fname.Text = "Firstname:";
            // 
            // Txtbox_Fname
            // 
            this.Txtbox_Fname.Location = new System.Drawing.Point(116, 74);
            this.Txtbox_Fname.Name = "Txtbox_Fname";
            this.Txtbox_Fname.Size = new System.Drawing.Size(114, 20);
            this.Txtbox_Fname.TabIndex = 4;
            // 
            // Btn_Profile
            // 
            this.Btn_Profile.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Btn_Profile.Location = new System.Drawing.Point(3, 176);
            this.Btn_Profile.Name = "Btn_Profile";
            this.Btn_Profile.Size = new System.Drawing.Size(121, 39);
            this.Btn_Profile.TabIndex = 8;
            this.Btn_Profile.Text = "Get My Profile";
            this.Btn_Profile.UseVisualStyleBackColor = true;
            this.Btn_Profile.Click += new System.EventHandler(this.Btn_Profile_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_hide.Location = new System.Drawing.Point(130, 176);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(69, 39);
            this.btn_hide.TabIndex = 9;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // Btn_bck
            // 
            this.Btn_bck.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Btn_bck.Location = new System.Drawing.Point(205, 176);
            this.Btn_bck.Name = "Btn_bck";
            this.Btn_bck.Size = new System.Drawing.Size(67, 39);
            this.Btn_bck.TabIndex = 10;
            this.Btn_bck.Text = "Back";
            this.Btn_bck.UseVisualStyleBackColor = true;
            this.Btn_bck.Click += new System.EventHandler(this.Btn_bck_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Btn_bck);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.Btn_Profile);
            this.Controls.Add(this.Label_Lname);
            this.Controls.Add(this.Txtbox_Lname);
            this.Controls.Add(this.Label_Fname);
            this.Controls.Add(this.Txtbox_Fname);
            this.Controls.Add(this.label_myprofile);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_myprofile;
        private System.Windows.Forms.Label Label_Lname;
        private System.Windows.Forms.TextBox Txtbox_Lname;
        private System.Windows.Forms.Label Label_Fname;
        private System.Windows.Forms.TextBox Txtbox_Fname;
        private System.Windows.Forms.Button Btn_Profile;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button Btn_bck;
    }
}