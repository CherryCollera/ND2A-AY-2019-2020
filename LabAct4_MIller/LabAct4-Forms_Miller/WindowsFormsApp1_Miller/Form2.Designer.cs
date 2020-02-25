namespace WindowsFormsApp1_Miller
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_fname = new System.Windows.Forms.TextBox();
            this.btn_message = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.txtBox_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // txtBox_fname
            // 
            this.txtBox_fname.Location = new System.Drawing.Point(154, 87);
            this.txtBox_fname.Name = "txtBox_fname";
            this.txtBox_fname.Size = new System.Drawing.Size(285, 26);
            this.txtBox_fname.TabIndex = 1;
            // 
            // btn_message
            // 
            this.btn_message.Location = new System.Drawing.Point(196, 208);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(182, 45);
            this.btn_message.TabIndex = 2;
            this.btn_message.Text = "Get Message";
            this.btn_message.UseVisualStyleBackColor = true;
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(235, 303);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(86, 37);
            this.btn_hide.TabIndex = 3;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // txtBox_Lname
            // 
            this.txtBox_Lname.Location = new System.Drawing.Point(154, 146);
            this.txtBox_Lname.Name = "txtBox_Lname";
            this.txtBox_Lname.Size = new System.Drawing.Size(285, 26);
            this.txtBox_Lname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 394);
            this.Controls.Add(this.txtBox_Lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_message);
            this.Controls.Add(this.txtBox_fname);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_fname;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.TextBox txtBox_Lname;
        private System.Windows.Forms.Label label2;
    }
}