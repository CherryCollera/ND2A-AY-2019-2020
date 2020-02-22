namespace WindowsFormsApp1_Miller
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
            this.txtBox_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_message = new System.Windows.Forms.Button();
            this.txtBox_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Lname
            // 
            this.txtBox_Lname.Location = new System.Drawing.Point(224, 133);
            this.txtBox_Lname.Name = "txtBox_Lname";
            this.txtBox_Lname.Size = new System.Drawing.Size(341, 26);
            this.txtBox_Lname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "LastName";
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(359, 241);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(86, 45);
            this.btn_hide.TabIndex = 9;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_message
            // 
            this.btn_message.Location = new System.Drawing.Point(140, 241);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(182, 45);
            this.btn_message.TabIndex = 8;
            this.btn_message.Text = "Get Message";
            this.btn_message.UseVisualStyleBackColor = true;
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click);
            // 
            // txtBox_fname
            // 
            this.txtBox_fname.Location = new System.Drawing.Point(224, 86);
            this.txtBox_fname.Name = "txtBox_fname";
            this.txtBox_fname.Size = new System.Drawing.Size(341, 26);
            this.txtBox_fname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "FirstName";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(479, 241);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(86, 45);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "My Profile";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txtBox_Lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_message);
            this.Controls.Add(this.txtBox_fname);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.TextBox txtBox_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label3;
    }
}