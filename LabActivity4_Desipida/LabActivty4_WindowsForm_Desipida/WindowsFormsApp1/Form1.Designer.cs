namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Getmessage = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Getmessage
            // 
            this.btn_Getmessage.BackColor = System.Drawing.Color.Gray;
            this.btn_Getmessage.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Getmessage.Location = new System.Drawing.Point(106, 230);
            this.btn_Getmessage.Name = "btn_Getmessage";
            this.btn_Getmessage.Size = new System.Drawing.Size(234, 50);
            this.btn_Getmessage.TabIndex = 0;
            this.btn_Getmessage.Text = "Get Message";
            this.btn_Getmessage.UseVisualStyleBackColor = false;
            this.btn_Getmessage.Click += new System.EventHandler(this.btn_Getmessage_Click);
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Hide.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide.Location = new System.Drawing.Point(288, 300);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(75, 33);
            this.Hide.TabIndex = 1;
            this.Hide.Text = "Hide";
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(433, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.btn_Getmessage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Getmessage;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

