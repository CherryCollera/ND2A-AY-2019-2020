﻿namespace Calculator
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
            this.BtnGetMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGetMessage
            // 
            this.BtnGetMessage.Location = new System.Drawing.Point(103, 112);
            this.BtnGetMessage.Name = "BtnGetMessage";
            this.BtnGetMessage.Size = new System.Drawing.Size(78, 23);
            this.BtnGetMessage.TabIndex = 0;
            this.BtnGetMessage.Text = "GetMessage!";
            this.BtnGetMessage.UseVisualStyleBackColor = true;
            this.BtnGetMessage.Click += new System.EventHandler(this.BtnGetMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnGetMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetMessage;
    }
}