namespace Calculator_Canlong
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
            this.btn_getmessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_getmessage
            // 
            this.btn_getmessage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_getmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getmessage.Location = new System.Drawing.Point(94, 118);
            this.btn_getmessage.Name = "btn_getmessage";
            this.btn_getmessage.Size = new System.Drawing.Size(119, 44);
            this.btn_getmessage.TabIndex = 0;
            this.btn_getmessage.Text = "Message";
            this.btn_getmessage.UseVisualStyleBackColor = false;
            this.btn_getmessage.Click += new System.EventHandler(this.Btn_GetMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(315, 292);
            this.Controls.Add(this.btn_getmessage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getmessage;
    }
}