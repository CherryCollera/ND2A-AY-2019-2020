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
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txtbox_fname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txtbox_lname = new System.Windows.Forms.TextBox();
            this.btn_GetMessage = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(45, 40);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(64, 17);
            this.lbl_fname.TabIndex = 0;
            this.lbl_fname.Text = "Firstname";
            this.lbl_fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox_fname
            // 
            this.txtbox_fname.BackColor = System.Drawing.Color.LightGray;
            this.txtbox_fname.Location = new System.Drawing.Point(109, 41);
            this.txtbox_fname.Name = "txtbox_fname";
            this.txtbox_fname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_fname.TabIndex = 1;
            this.txtbox_fname.TextChanged += new System.EventHandler(this.txtbox_fname_TextChanged);
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(45, 67);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 17);
            this.lbl_lname.TabIndex = 2;
            this.lbl_lname.Text = "Lastname";
            // 
            // txtbox_lname
            // 
            this.txtbox_lname.BackColor = System.Drawing.Color.LightGray;
            this.txtbox_lname.Location = new System.Drawing.Point(109, 67);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_lname.TabIndex = 3;
            // 
            // btn_GetMessage
            // 
            this.btn_GetMessage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_GetMessage.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_GetMessage.Location = new System.Drawing.Point(80, 117);
            this.btn_GetMessage.Name = "btn_GetMessage";
            this.btn_GetMessage.Size = new System.Drawing.Size(102, 42);
            this.btn_GetMessage.TabIndex = 4;
            this.btn_GetMessage.Text = "Get Message!";
            this.btn_GetMessage.UseVisualStyleBackColor = false;
            this.btn_GetMessage.Click += new System.EventHandler(this.btn_GetMessage_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Hide.Font = new System.Drawing.Font("Bradley Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Hide.Location = new System.Drawing.Point(166, 188);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(75, 23);
            this.btn_Hide.TabIndex = 5;
            this.btn_Hide.Text = "Hide";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Orange;
            this.btn_Back.Font = new System.Drawing.Font("Bradley Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Green;
            this.btn_Back.Location = new System.Drawing.Point(166, 217);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_GetMessage);
            this.Controls.Add(this.txtbox_lname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.txtbox_fname);
            this.Controls.Add(this.lbl_fname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txtbox_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txtbox_lname;
        private System.Windows.Forms.Button btn_GetMessage;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_Back;
    }
}