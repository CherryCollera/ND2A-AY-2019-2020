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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.btn_GetMyProfile = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbox_Fname.Location = new System.Drawing.Point(103, 63);
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Fname.TabIndex = 3;
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbox_Lname.Location = new System.Drawing.Point(103, 93);
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Lname.TabIndex = 4;
            // 
            // btn_GetMyProfile
            // 
            this.btn_GetMyProfile.BackColor = System.Drawing.Color.Aqua;
            this.btn_GetMyProfile.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetMyProfile.Location = new System.Drawing.Point(12, 147);
            this.btn_GetMyProfile.Name = "btn_GetMyProfile";
            this.btn_GetMyProfile.Size = new System.Drawing.Size(75, 59);
            this.btn_GetMyProfile.TabIndex = 5;
            this.btn_GetMyProfile.Text = "Get My Profile";
            this.btn_GetMyProfile.UseVisualStyleBackColor = false;
            this.btn_GetMyProfile.Click += new System.EventHandler(this.btn_GetMyProfile_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Lime;
            this.btn_Hide.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.Location = new System.Drawing.Point(116, 165);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(75, 23);
            this.btn_Hide.TabIndex = 6;
            this.btn_Hide.Text = "Hide";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Lime;
            this.btn_Back.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(197, 165);
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
            this.Controls.Add(this.txtbox_Lname);
            this.Controls.Add(this.txtbox_Fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.Button btn_GetMyProfile;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_Back;
    }
}