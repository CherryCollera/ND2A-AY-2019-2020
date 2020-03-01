namespace GreetMe
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
            this.bttn_GetMessage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_Hide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_GetMessage
            // 
            this.bttn_GetMessage.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_GetMessage.Location = new System.Drawing.Point(74, 115);
            this.bttn_GetMessage.Name = "bttn_GetMessage";
            this.bttn_GetMessage.Size = new System.Drawing.Size(117, 30);
            this.bttn_GetMessage.TabIndex = 0;
            this.bttn_GetMessage.Text = "Get Message";
            this.bttn_GetMessage.UseVisualStyleBackColor = true;
            this.bttn_GetMessage.Click += new System.EventHandler(this.bttn_GetMessage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bttn_Hide
            // 
            this.bttn_Hide.Location = new System.Drawing.Point(197, 161);
            this.bttn_Hide.Name = "bttn_Hide";
            this.bttn_Hide.Size = new System.Drawing.Size(75, 23);
            this.bttn_Hide.TabIndex = 2;
            this.bttn_Hide.Text = "Hide";
            this.bttn_Hide.UseVisualStyleBackColor = true;
            this.bttn_Hide.Click += new System.EventHandler(this.bttn_Hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.bttn_Hide);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_GetMessage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_GetMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttn_Hide;
    }
}

