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
            this.lbl_LN = new System.Windows.Forms.Label();
            this.lbl_FN = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn_GetMessage = new System.Windows.Forms.Button();
            this.bttn_Hide = new System.Windows.Forms.Button();
            this.bttn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_LN
            // 
            this.lbl_LN.AutoSize = true;
            this.lbl_LN.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LN.Location = new System.Drawing.Point(24, 86);
            this.lbl_LN.Name = "lbl_LN";
            this.lbl_LN.Size = new System.Drawing.Size(100, 19);
            this.lbl_LN.TabIndex = 7;
            this.lbl_LN.Text = "Last Name:";
            // 
            // lbl_FN
            // 
            this.lbl_FN.AutoSize = true;
            this.lbl_FN.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FN.Location = new System.Drawing.Point(21, 57);
            this.lbl_FN.Name = "lbl_FN";
            this.lbl_FN.Size = new System.Drawing.Size(104, 19);
            this.lbl_FN.TabIndex = 6;
            this.lbl_FN.Text = "First Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // bttn_GetMessage
            // 
            this.bttn_GetMessage.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_GetMessage.Location = new System.Drawing.Point(68, 135);
            this.bttn_GetMessage.Name = "bttn_GetMessage";
            this.bttn_GetMessage.Size = new System.Drawing.Size(117, 30);
            this.bttn_GetMessage.TabIndex = 8;
            this.bttn_GetMessage.Text = "Get Message";
            this.bttn_GetMessage.UseVisualStyleBackColor = true;
            this.bttn_GetMessage.Click += new System.EventHandler(this.bttn_GetMessage_Click);
            // 
            // bttn_Hide
            // 
            this.bttn_Hide.Location = new System.Drawing.Point(178, 198);
            this.bttn_Hide.Name = "bttn_Hide";
            this.bttn_Hide.Size = new System.Drawing.Size(75, 23);
            this.bttn_Hide.TabIndex = 9;
            this.bttn_Hide.Text = "Hide";
            this.bttn_Hide.UseVisualStyleBackColor = true;
            this.bttn_Hide.Click += new System.EventHandler(this.bttn_Hide_Click);
            // 
            // bttn_Back
            // 
            this.bttn_Back.Location = new System.Drawing.Point(28, 198);
            this.bttn_Back.Name = "bttn_Back";
            this.bttn_Back.Size = new System.Drawing.Size(75, 23);
            this.bttn_Back.TabIndex = 10;
            this.bttn_Back.Text = "Back";
            this.bttn_Back.UseVisualStyleBackColor = true;
            this.bttn_Back.Click += new System.EventHandler(this.bttn_Back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttn_Back);
            this.Controls.Add(this.bttn_Hide);
            this.Controls.Add(this.bttn_GetMessage);
            this.Controls.Add(this.lbl_LN);
            this.Controls.Add(this.lbl_FN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LN;
        private System.Windows.Forms.Label lbl_FN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttn_GetMessage;
        private System.Windows.Forms.Button bttn_Hide;
        private System.Windows.Forms.Button bttn_Back;
    }
}