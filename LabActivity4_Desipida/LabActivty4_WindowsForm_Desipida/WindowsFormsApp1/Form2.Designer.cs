namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Fisrtname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GetMessage = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fisrtname
            // 
            this.Fisrtname.AutoSize = true;
            this.Fisrtname.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fisrtname.Location = new System.Drawing.Point(59, 61);
            this.Fisrtname.Name = "Fisrtname";
            this.Fisrtname.Size = new System.Drawing.Size(83, 19);
            this.Fisrtname.TabIndex = 0;
            this.Fisrtname.Text = "First Name:";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(169, 59);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(198, 22);
            this.Fname.TabIndex = 1;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(169, 101);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(198, 22);
            this.Lname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // btn_GetMessage
            // 
            this.btn_GetMessage.AccessibleName = "";
            this.btn_GetMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_GetMessage.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetMessage.Location = new System.Drawing.Point(193, 146);
            this.btn_GetMessage.Name = "btn_GetMessage";
            this.btn_GetMessage.Size = new System.Drawing.Size(153, 62);
            this.btn_GetMessage.TabIndex = 5;
            this.btn_GetMessage.Text = "Get Message";
            this.btn_GetMessage.UseVisualStyleBackColor = false;
            this.btn_GetMessage.Click += new System.EventHandler(this.btn_getmessage_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back.Location = new System.Drawing.Point(348, 256);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 30);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.back);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(485, 304);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.btn_GetMessage);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Fisrtname);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fisrtname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GetMessage;
        private System.Windows.Forms.Button Back;
    }
}