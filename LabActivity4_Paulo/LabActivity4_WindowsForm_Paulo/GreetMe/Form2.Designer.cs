namespace GreetMe
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
            this.Txtbox_Fname = new System.Windows.Forms.TextBox();
            this.Label_Fname = new System.Windows.Forms.Label();
            this.Label_Lname = new System.Windows.Forms.Label();
            this.Txtbox_Lname = new System.Windows.Forms.TextBox();
            this.btn_GetMessage = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtbox_Fname
            // 
            this.Txtbox_Fname.Location = new System.Drawing.Point(107, 41);
            this.Txtbox_Fname.Name = "Txtbox_Fname";
            this.Txtbox_Fname.Size = new System.Drawing.Size(114, 20);
            this.Txtbox_Fname.TabIndex = 0;
            this.Txtbox_Fname.TextChanged += new System.EventHandler(this.Txtbox_Fname_TextChanged);
            // 
            // Label_Fname
            // 
            this.Label_Fname.AutoSize = true;
            this.Label_Fname.Location = new System.Drawing.Point(46, 41);
            this.Label_Fname.Name = "Label_Fname";
            this.Label_Fname.Size = new System.Drawing.Size(55, 13);
            this.Label_Fname.TabIndex = 1;
            this.Label_Fname.Text = "Firstname:";
            // 
            // Label_Lname
            // 
            this.Label_Lname.AutoSize = true;
            this.Label_Lname.Location = new System.Drawing.Point(46, 86);
            this.Label_Lname.Name = "Label_Lname";
            this.Label_Lname.Size = new System.Drawing.Size(56, 13);
            this.Label_Lname.TabIndex = 3;
            this.Label_Lname.Text = "Lastname:";
            // 
            // Txtbox_Lname
            // 
            this.Txtbox_Lname.Location = new System.Drawing.Point(107, 86);
            this.Txtbox_Lname.Name = "Txtbox_Lname";
            this.Txtbox_Lname.Size = new System.Drawing.Size(114, 20);
            this.Txtbox_Lname.TabIndex = 2;
            // 
            // btn_GetMessage
            // 
            this.btn_GetMessage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_GetMessage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetMessage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_GetMessage.Location = new System.Drawing.Point(105, 144);
            this.btn_GetMessage.Name = "btn_GetMessage";
            this.btn_GetMessage.Size = new System.Drawing.Size(116, 50);
            this.btn_GetMessage.TabIndex = 4;
            this.btn_GetMessage.Text = "Get Message";
            this.btn_GetMessage.UseVisualStyleBackColor = false;
            this.btn_GetMessage.Click += new System.EventHandler(this.btn_GetMessage_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_hide.Location = new System.Drawing.Point(205, 213);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(67, 36);
            this.btn_hide.TabIndex = 5;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_GetMessage);
            this.Controls.Add(this.Label_Lname);
            this.Controls.Add(this.Txtbox_Lname);
            this.Controls.Add(this.Label_Fname);
            this.Controls.Add(this.Txtbox_Fname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtbox_Fname;
        private System.Windows.Forms.Label Label_Fname;
        private System.Windows.Forms.Label Label_Lname;
        private System.Windows.Forms.TextBox Txtbox_Lname;
        private System.Windows.Forms.Button btn_GetMessage;
        private System.Windows.Forms.Button btn_hide;
    }
}