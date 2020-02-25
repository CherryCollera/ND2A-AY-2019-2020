namespace LabActivity4_Valerio_Form
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
            this.txt_FName = new System.Windows.Forms.Label();
            this.txt_LName = new System.Windows.Forms.Label();
            this.txtBox_fname = new System.Windows.Forms.TextBox();
            this.txtBox_lname = new System.Windows.Forms.TextBox();
            this.btn_getmessage = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_bck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_FName
            // 
            this.txt_FName.AutoSize = true;
            this.txt_FName.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FName.Location = new System.Drawing.Point(25, 32);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(67, 15);
            this.txt_FName.TabIndex = 0;
            this.txt_FName.Text = "FirstName";
            // 
            // txt_LName
            // 
            this.txt_LName.AutoSize = true;
            this.txt_LName.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LName.Location = new System.Drawing.Point(27, 61);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(65, 15);
            this.txt_LName.TabIndex = 1;
            this.txt_LName.Text = "LastName";
            // 
            // txtBox_fname
            // 
            this.txtBox_fname.Location = new System.Drawing.Point(98, 30);
            this.txtBox_fname.Name = "txtBox_fname";
            this.txtBox_fname.Size = new System.Drawing.Size(159, 20);
            this.txtBox_fname.TabIndex = 2;
            // 
            // txtBox_lname
            // 
            this.txtBox_lname.Location = new System.Drawing.Point(98, 59);
            this.txtBox_lname.Name = "txtBox_lname";
            this.txtBox_lname.Size = new System.Drawing.Size(158, 20);
            this.txtBox_lname.TabIndex = 3;
            // 
            // btn_getmessage
            // 
            this.btn_getmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_getmessage.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getmessage.ForeColor = System.Drawing.Color.Violet;
            this.btn_getmessage.Location = new System.Drawing.Point(72, 143);
            this.btn_getmessage.Name = "btn_getmessage";
            this.btn_getmessage.Size = new System.Drawing.Size(138, 56);
            this.btn_getmessage.TabIndex = 4;
            this.btn_getmessage.Text = "Get Message";
            this.btn_getmessage.UseVisualStyleBackColor = false;
            this.btn_getmessage.Click += new System.EventHandler(this.btn_getmessage_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Gray;
            this.btn_hide.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.Color.Yellow;
            this.btn_hide.Location = new System.Drawing.Point(98, 221);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(84, 28);
            this.btn_hide.TabIndex = 5;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_bck
            // 
            this.btn_bck.BackColor = System.Drawing.Color.Gray;
            this.btn_bck.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bck.ForeColor = System.Drawing.Color.Yellow;
            this.btn_bck.Location = new System.Drawing.Point(188, 221);
            this.btn_bck.Name = "btn_bck";
            this.btn_bck.Size = new System.Drawing.Size(84, 28);
            this.btn_bck.TabIndex = 6;
            this.btn_bck.Text = "Back";
            this.btn_bck.UseVisualStyleBackColor = false;
            this.btn_bck.Click += new System.EventHandler(this.btn_bck_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_bck);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_getmessage);
            this.Controls.Add(this.txtBox_lname);
            this.Controls.Add(this.txtBox_fname);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.txt_FName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_FName;
        private System.Windows.Forms.Label txt_LName;
        private System.Windows.Forms.TextBox txtBox_fname;
        private System.Windows.Forms.TextBox txtBox_lname;
        private System.Windows.Forms.Button btn_getmessage;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_bck;
    }
}