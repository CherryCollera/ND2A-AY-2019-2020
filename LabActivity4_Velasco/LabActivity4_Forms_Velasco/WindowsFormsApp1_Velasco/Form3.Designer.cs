namespace WindowsFormsApp1_Velasco
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txtBox_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_message = new System.Windows.Forms.Button();
            this.txtBox_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "My Profile";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(229, 191);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(57, 29);
            this.btn_Back.TabIndex = 20;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txtBox_Lname
            // 
            this.txtBox_Lname.Location = new System.Drawing.Point(57, 120);
            this.txtBox_Lname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Lname.Name = "txtBox_Lname";
            this.txtBox_Lname.Size = new System.Drawing.Size(229, 20);
            this.txtBox_Lname.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "LastName";
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(147, 191);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(57, 29);
            this.btn_hide.TabIndex = 17;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_message
            // 
            this.btn_message.Location = new System.Drawing.Point(1, 191);
            this.btn_message.Margin = new System.Windows.Forms.Padding(2);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(121, 29);
            this.btn_message.TabIndex = 16;
            this.btn_message.Text = "Get Message";
            this.btn_message.UseVisualStyleBackColor = true;
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click);
            // 
            // txtBox_fname
            // 
            this.txtBox_fname.Location = new System.Drawing.Point(57, 90);
            this.txtBox_fname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_fname.Name = "txtBox_fname";
            this.txtBox_fname.Size = new System.Drawing.Size(229, 20);
            this.txtBox_fname.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "FirstName";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txtBox_Lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_message);
            this.Controls.Add(this.txtBox_fname);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txtBox_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.TextBox txtBox_fname;
        private System.Windows.Forms.Label label1;
    }
}