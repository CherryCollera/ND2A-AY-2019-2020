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
            this.lbl_LN = new System.Windows.Forms.Label();
            this.lbl_FN = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn_Back = new System.Windows.Forms.Button();
            this.bttn_Hide = new System.Windows.Forms.Button();
            this.bttn_GetMyProfile = new System.Windows.Forms.Button();
            this.lbl_MyProfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_LN
            // 
            this.lbl_LN.AutoSize = true;
            this.lbl_LN.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LN.Location = new System.Drawing.Point(71, 120);
            this.lbl_LN.Name = "lbl_LN";
            this.lbl_LN.Size = new System.Drawing.Size(100, 19);
            this.lbl_LN.TabIndex = 11;
            this.lbl_LN.Text = "Last Name:";
            // 
            // lbl_FN
            // 
            this.lbl_FN.AutoSize = true;
            this.lbl_FN.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FN.Location = new System.Drawing.Point(68, 91);
            this.lbl_FN.Name = "lbl_FN";
            this.lbl_FN.Size = new System.Drawing.Size(104, 19);
            this.lbl_FN.TabIndex = 10;
            this.lbl_FN.Text = "First Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // bttn_Back
            // 
            this.bttn_Back.Location = new System.Drawing.Point(12, 244);
            this.bttn_Back.Name = "bttn_Back";
            this.bttn_Back.Size = new System.Drawing.Size(75, 23);
            this.bttn_Back.TabIndex = 12;
            this.bttn_Back.Text = "Back";
            this.bttn_Back.UseVisualStyleBackColor = true;
            this.bttn_Back.Click += new System.EventHandler(this.bttn_Back_Click);
            // 
            // bttn_Hide
            // 
            this.bttn_Hide.Location = new System.Drawing.Point(284, 244);
            this.bttn_Hide.Name = "bttn_Hide";
            this.bttn_Hide.Size = new System.Drawing.Size(75, 23);
            this.bttn_Hide.TabIndex = 13;
            this.bttn_Hide.Text = "Hide";
            this.bttn_Hide.UseVisualStyleBackColor = true;
            this.bttn_Hide.Click += new System.EventHandler(this.bttn_Hide_Click);
            // 
            // bttn_GetMyProfile
            // 
            this.bttn_GetMyProfile.Location = new System.Drawing.Point(133, 159);
            this.bttn_GetMyProfile.Name = "bttn_GetMyProfile";
            this.bttn_GetMyProfile.Size = new System.Drawing.Size(91, 34);
            this.bttn_GetMyProfile.TabIndex = 14;
            this.bttn_GetMyProfile.Text = "Get My Profile";
            this.bttn_GetMyProfile.UseVisualStyleBackColor = true;
            this.bttn_GetMyProfile.Click += new System.EventHandler(this.bttn_GetMyProfile_Click);
            // 
            // lbl_MyProfile
            // 
            this.lbl_MyProfile.AutoSize = true;
            this.lbl_MyProfile.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MyProfile.Location = new System.Drawing.Point(90, 30);
            this.lbl_MyProfile.Name = "lbl_MyProfile";
            this.lbl_MyProfile.Size = new System.Drawing.Size(168, 32);
            this.lbl_MyProfile.TabIndex = 15;
            this.lbl_MyProfile.Text = "My Profile";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 298);
            this.Controls.Add(this.lbl_MyProfile);
            this.Controls.Add(this.bttn_GetMyProfile);
            this.Controls.Add(this.bttn_Hide);
            this.Controls.Add(this.bttn_Back);
            this.Controls.Add(this.lbl_LN);
            this.Controls.Add(this.lbl_FN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LN;
        private System.Windows.Forms.Label lbl_FN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttn_Back;
        private System.Windows.Forms.Button bttn_Hide;
        private System.Windows.Forms.Button bttn_GetMyProfile;
        private System.Windows.Forms.Label lbl_MyProfile;
    }
}