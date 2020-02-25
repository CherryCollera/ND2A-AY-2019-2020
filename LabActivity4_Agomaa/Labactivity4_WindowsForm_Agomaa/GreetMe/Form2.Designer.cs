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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GetMessage = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.Location = new System.Drawing.Point(90, 36);
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(172, 20);
            this.txtbox_Fname.TabIndex = 1;
            this.txtbox_Fname.TextChanged += new System.EventHandler(this.txtbox_Fname_TextChanged);
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.Location = new System.Drawing.Point(90, 74);
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(172, 20);
            this.txtbox_Lname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname";
            // 
            // btn_GetMessage
            // 
            this.btn_GetMessage.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetMessage.Location = new System.Drawing.Point(60, 134);
            this.btn_GetMessage.Name = "btn_GetMessage";
            this.btn_GetMessage.Size = new System.Drawing.Size(141, 36);
            this.btn_GetMessage.TabIndex = 4;
            this.btn_GetMessage.Text = "Get Message";
            this.btn_GetMessage.UseVisualStyleBackColor = true;
            this.btn_GetMessage.Click += new System.EventHandler(this.btn_GetMessage_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.Location = new System.Drawing.Point(187, 215);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(75, 23);
            this.btn_Hide.TabIndex = 5;
            this.btn_Hide.Text = "Hide";
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(23, 215);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.txtbox_Lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_Fname);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GetMessage;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_Back;
    }
}