namespace WindowsForm1_Canlong
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
            this.box_fn = new System.Windows.Forms.TextBox();
            this.btn_fn = new System.Windows.Forms.Label();
            this.box_ln = new System.Windows.Forms.TextBox();
            this.btn_ln = new System.Windows.Forms.Label();
            this.btn_msg = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // box_fn
            // 
            this.box_fn.Location = new System.Drawing.Point(234, 68);
            this.box_fn.Name = "box_fn";
            this.box_fn.Size = new System.Drawing.Size(144, 22);
            this.box_fn.TabIndex = 8;
            this.box_fn.TextChanged += new System.EventHandler(this.box_fn_TextChanged);
            // 
            // btn_fn
            // 
            this.btn_fn.AutoSize = true;
            this.btn_fn.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fn.Location = new System.Drawing.Point(105, 68);
            this.btn_fn.Name = "btn_fn";
            this.btn_fn.Size = new System.Drawing.Size(105, 20);
            this.btn_fn.TabIndex = 6;
            this.btn_fn.Text = "FirstName:";
            // 
            // box_ln
            // 
            this.box_ln.Location = new System.Drawing.Point(234, 114);
            this.box_ln.Name = "box_ln";
            this.box_ln.Size = new System.Drawing.Size(144, 22);
            this.box_ln.TabIndex = 13;
            // 
            // btn_ln
            // 
            this.btn_ln.AutoSize = true;
            this.btn_ln.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ln.Location = new System.Drawing.Point(105, 114);
            this.btn_ln.Name = "btn_ln";
            this.btn_ln.Size = new System.Drawing.Size(101, 20);
            this.btn_ln.TabIndex = 12;
            this.btn_ln.Text = "LastName:";
            // 
            // btn_msg
            // 
            this.btn_msg.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_msg.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_msg.Location = new System.Drawing.Point(133, 161);
            this.btn_msg.Name = "btn_msg";
            this.btn_msg.Size = new System.Drawing.Size(219, 74);
            this.btn_msg.TabIndex = 14;
            this.btn_msg.Text = "Get Message";
            this.btn_msg.UseVisualStyleBackColor = false;
            this.btn_msg.Click += new System.EventHandler(this.btn_msg_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_next.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(351, 349);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 38);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_back.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(38, 349);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 38);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForm1_Canlong.Properties.Resources.technology_background__digital_hand__simple_background_with_co;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 440);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 429);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_msg);
            this.Controls.Add(this.box_ln);
            this.Controls.Add(this.btn_ln);
            this.Controls.Add(this.box_fn);
            this.Controls.Add(this.btn_fn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_fn;
        private System.Windows.Forms.Label btn_fn;
        private System.Windows.Forms.TextBox box_ln;
        private System.Windows.Forms.Label btn_ln;
        private System.Windows.Forms.Button btn_msg;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}