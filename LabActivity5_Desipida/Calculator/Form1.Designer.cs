namespace Calculator
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
            this.Btn_Getmessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Getmessage
            // 
            this.Btn_Getmessage.BackColor = System.Drawing.Color.Snow;
            this.Btn_Getmessage.Location = new System.Drawing.Point(104, 167);
            this.Btn_Getmessage.Name = "Btn_Getmessage";
            this.Btn_Getmessage.Size = new System.Drawing.Size(142, 44);
            this.Btn_Getmessage.TabIndex = 0;
            this.Btn_Getmessage.Text = "Get Message";
            this.Btn_Getmessage.UseVisualStyleBackColor = false;
            this.Btn_Getmessage.Click += new System.EventHandler(this.Btn_Getmessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(343, 346);
            this.Controls.Add(this.Btn_Getmessage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Getmessage;
    }
}