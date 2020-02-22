namespace WindowsForm1_Canlong
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
            this.box_ln = new System.Windows.Forms.TextBox();
            this.btn_ln = new System.Windows.Forms.Label();
            this.box_fn = new System.Windows.Forms.TextBox();
            this.btn_fn = new System.Windows.Forms.Label();
            this.btn_mp = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_calcu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // box_ln
            // 
            this.box_ln.Location = new System.Drawing.Point(250, 145);
            this.box_ln.Name = "box_ln";
            this.box_ln.Size = new System.Drawing.Size(144, 22);
            this.box_ln.TabIndex = 17;
            // 
            // btn_ln
            // 
            this.btn_ln.AutoSize = true;
            this.btn_ln.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ln.Location = new System.Drawing.Point(115, 147);
            this.btn_ln.Name = "btn_ln";
            this.btn_ln.Size = new System.Drawing.Size(101, 20);
            this.btn_ln.TabIndex = 16;
            this.btn_ln.Text = "LastName:";
            // 
            // box_fn
            // 
            this.box_fn.Location = new System.Drawing.Point(250, 99);
            this.box_fn.Name = "box_fn";
            this.box_fn.Size = new System.Drawing.Size(144, 22);
            this.box_fn.TabIndex = 15;
            // 
            // btn_fn
            // 
            this.btn_fn.AutoSize = true;
            this.btn_fn.BackColor = System.Drawing.Color.Transparent;
            this.btn_fn.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fn.Location = new System.Drawing.Point(115, 101);
            this.btn_fn.Name = "btn_fn";
            this.btn_fn.Size = new System.Drawing.Size(105, 20);
            this.btn_fn.TabIndex = 14;
            this.btn_fn.Text = "FirstName:";
            // 
            // btn_mp
            // 
            this.btn_mp.BackColor = System.Drawing.Color.Aqua;
            this.btn_mp.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mp.Location = new System.Drawing.Point(131, 195);
            this.btn_mp.Name = "btn_mp";
            this.btn_mp.Size = new System.Drawing.Size(225, 69);
            this.btn_mp.TabIndex = 18;
            this.btn_mp.Text = "Get MyProfile";
            this.btn_mp.UseVisualStyleBackColor = false;
            this.btn_mp.Click += new System.EventHandler(this.btn_mp_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_hide.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.Location = new System.Drawing.Point(315, 356);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(113, 46);
            this.btn_hide.TabIndex = 19;
            this.btn_hide.Text = "HIDE";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_back.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(55, 356);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(113, 46);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_calcu
            // 
            this.btn_calcu.BackColor = System.Drawing.Color.Aqua;
            this.btn_calcu.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcu.Location = new System.Drawing.Point(185, 283);
            this.btn_calcu.Name = "btn_calcu";
            this.btn_calcu.Size = new System.Drawing.Size(122, 46);
            this.btn_calcu.TabIndex = 21;
            this.btn_calcu.Text = "CALCULATOR";
            this.btn_calcu.UseVisualStyleBackColor = false;
            this.btn_calcu.Click += new System.EventHandler(this.btn_calcu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 58);
            this.label1.TabIndex = 22;
            this.label1.Text = "My Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForm1_Canlong.Properties.Resources.technology_background__digital_hand__simple_background_with_co;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 444);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcu);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_mp);
            this.Controls.Add(this.box_ln);
            this.Controls.Add(this.btn_ln);
            this.Controls.Add(this.box_fn);
            this.Controls.Add(this.btn_fn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_ln;
        private System.Windows.Forms.Label btn_ln;
        private System.Windows.Forms.TextBox box_fn;
        private System.Windows.Forms.Label btn_fn;
        private System.Windows.Forms.Button btn_mp;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_calcu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}