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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.txtBox_LN = new System.Windows.Forms.TextBox();
            this.txtBox_FN = new System.Windows.Forms.TextBox();
            this.btn_MyProfile = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LName.Location = new System.Drawing.Point(53, 196);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(89, 22);
            this.lbl_LName.TabIndex = 7;
            this.lbl_LName.Text = "Last Name:";
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FName.Location = new System.Drawing.Point(53, 167);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(90, 22);
            this.lbl_FName.TabIndex = 6;
            this.lbl_FName.Text = "First Name:";
            // 
            // txtBox_LN
            // 
            this.txtBox_LN.Location = new System.Drawing.Point(160, 199);
            this.txtBox_LN.Name = "txtBox_LN";
            this.txtBox_LN.Size = new System.Drawing.Size(130, 20);
            this.txtBox_LN.TabIndex = 5;
            // 
            // txtBox_FN
            // 
            this.txtBox_FN.Location = new System.Drawing.Point(160, 170);
            this.txtBox_FN.Name = "txtBox_FN";
            this.txtBox_FN.Size = new System.Drawing.Size(130, 20);
            this.txtBox_FN.TabIndex = 4;
            // 
            // btn_MyProfile
            // 
            this.btn_MyProfile.BackColor = System.Drawing.Color.LightCoral;
            this.btn_MyProfile.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MyProfile.Location = new System.Drawing.Point(27, 242);
            this.btn_MyProfile.Name = "btn_MyProfile";
            this.btn_MyProfile.Size = new System.Drawing.Size(123, 31);
            this.btn_MyProfile.TabIndex = 8;
            this.btn_MyProfile.Text = "Get My Profile";
            this.btn_MyProfile.UseVisualStyleBackColor = false;
            this.btn_MyProfile.Click += new System.EventHandler(this.btn_MyProfile_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Hide.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.Location = new System.Drawing.Point(171, 242);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(90, 31);
            this.btn_Hide.TabIndex = 9;
            this.btn_Hide.Text = "Hide";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Back.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(283, 242);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(90, 31);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(113, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 99);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(408, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_MyProfile);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.txtBox_LN);
            this.Controls.Add(this.txtBox_FN);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.TextBox txtBox_LN;
        private System.Windows.Forms.TextBox txtBox_FN;
        private System.Windows.Forms.Button btn_MyProfile;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}