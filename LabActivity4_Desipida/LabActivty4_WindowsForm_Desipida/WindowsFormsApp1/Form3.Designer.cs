namespace WindowsFormsApp1
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
            this.Lname = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.Lastn = new System.Windows.Forms.Label();
            this.Firstn = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.Getmyprofile = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(189, 135);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(169, 22);
            this.Lname.TabIndex = 18;
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(189, 92);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(169, 22);
            this.FName.TabIndex = 17;
            // 
            // Lastn
            // 
            this.Lastn.AutoSize = true;
            this.Lastn.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastn.Location = new System.Drawing.Point(50, 140);
            this.Lastn.Name = "Lastn";
            this.Lastn.Size = new System.Drawing.Size(87, 18);
            this.Lastn.TabIndex = 16;
            this.Lastn.Text = "Last Name:";
            // 
            // Firstn
            // 
            this.Firstn.AutoSize = true;
            this.Firstn.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstn.Location = new System.Drawing.Point(50, 92);
            this.Firstn.Name = "Firstn";
            this.Firstn.Size = new System.Drawing.Size(90, 18);
            this.Firstn.TabIndex = 15;
            this.Firstn.Text = "First Name:";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Lime;
            this.Back.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(286, 211);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 37);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.Color.Red;
            this.Hide.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide.Location = new System.Drawing.Point(193, 211);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(87, 38);
            this.Hide.TabIndex = 13;
            this.Hide.Text = "Hide";
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Getmyprofile
            // 
            this.Getmyprofile.AccessibleName = "btn_GetMessage";
            this.Getmyprofile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Getmyprofile.Font = new System.Drawing.Font("Rockwell", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Getmyprofile.Location = new System.Drawing.Point(53, 210);
            this.Getmyprofile.Name = "Getmyprofile";
            this.Getmyprofile.Size = new System.Drawing.Size(134, 38);
            this.Getmyprofile.TabIndex = 12;
            this.Getmyprofile.Text = "Get My Profile";
            this.Getmyprofile.UseVisualStyleBackColor = false;
            this.Getmyprofile.Click += new System.EventHandler(this.Getmyprofile_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.AutoSize = true;
            this.MyProfile.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyProfile.Location = new System.Drawing.Point(92, 19);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(233, 49);
            this.MyProfile.TabIndex = 19;
            this.MyProfile.Text = "My Profile";
            this.MyProfile.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(424, 290);
            this.Controls.Add(this.MyProfile);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.Lastn);
            this.Controls.Add(this.Firstn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.Getmyprofile);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label Lastn;
        private System.Windows.Forms.Label Firstn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button Getmyprofile;
        private System.Windows.Forms.Label MyProfile;
    }
}