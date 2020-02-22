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
            this.lbl_MyProfile = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txtbox_fname = new System.Windows.Forms.TextBox();
            this.txtbox_lname = new System.Windows.Forms.TextBox();
            this.btn_GetMyProfile = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MyProfile
            // 
            this.lbl_MyProfile.AutoSize = true;
            this.lbl_MyProfile.Font = new System.Drawing.Font("French Script MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MyProfile.Location = new System.Drawing.Point(61, 19);
            this.lbl_MyProfile.Name = "lbl_MyProfile";
            this.lbl_MyProfile.Size = new System.Drawing.Size(158, 42);
            this.lbl_MyProfile.TabIndex = 0;
            this.lbl_MyProfile.Text = "My Profile";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(35, 83);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(64, 17);
            this.lbl_fname.TabIndex = 1;
            this.lbl_fname.Text = "Firstname";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(35, 116);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 17);
            this.lbl_lname.TabIndex = 2;
            this.lbl_lname.Text = "Lastname";
            // 
            // txtbox_fname
            // 
            this.txtbox_fname.Location = new System.Drawing.Point(104, 83);
            this.txtbox_fname.Name = "txtbox_fname";
            this.txtbox_fname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_fname.TabIndex = 3;
            // 
            // txtbox_lname
            // 
            this.txtbox_lname.Location = new System.Drawing.Point(104, 113);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_lname.TabIndex = 4;
            this.txtbox_lname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_GetMyProfile
            // 
            this.btn_GetMyProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_GetMyProfile.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetMyProfile.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_GetMyProfile.Location = new System.Drawing.Point(12, 173);
            this.btn_GetMyProfile.Name = "btn_GetMyProfile";
            this.btn_GetMyProfile.Size = new System.Drawing.Size(98, 35);
            this.btn_GetMyProfile.TabIndex = 5;
            this.btn_GetMyProfile.Text = "Get My Profile!";
            this.btn_GetMyProfile.UseVisualStyleBackColor = false;
            this.btn_GetMyProfile.Click += new System.EventHandler(this.btn_GetMyProfile_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Hide.Font = new System.Drawing.Font("Bradley Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Hide.Location = new System.Drawing.Point(116, 181);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(75, 23);
            this.btn_Hide.TabIndex = 6;
            this.btn_Hide.Text = "Hide";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Orange;
            this.btn_Back.Font = new System.Drawing.Font("Bradley Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Green;
            this.btn_Back.Location = new System.Drawing.Point(197, 181);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_GetMyProfile);
            this.Controls.Add(this.txtbox_lname);
            this.Controls.Add(this.txtbox_fname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_MyProfile);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MyProfile;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txtbox_fname;
        private System.Windows.Forms.TextBox txtbox_lname;
        private System.Windows.Forms.Button btn_GetMyProfile;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_Back;
    }
}