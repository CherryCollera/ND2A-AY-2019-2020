namespace WindowsForm1_Canlong
{
    partial class Form4
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
            this.box_no1 = new System.Windows.Forms.TextBox();
            this.lbl_no1 = new System.Windows.Forms.Label();
            this.box_no2 = new System.Windows.Forms.TextBox();
            this.lbl_no2 = new System.Windows.Forms.Label();
            this.btn_substract = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_remainder = new System.Windows.Forms.Button();
            this.box_answer = new System.Windows.Forms.TextBox();
            this.lbl_ans = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // box_no1
            // 
            this.box_no1.Location = new System.Drawing.Point(290, 46);
            this.box_no1.Name = "box_no1";
            this.box_no1.Size = new System.Drawing.Size(71, 22);
            this.box_no1.TabIndex = 19;
            // 
            // lbl_no1
            // 
            this.lbl_no1.AutoSize = true;
            this.lbl_no1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no1.Location = new System.Drawing.Point(136, 46);
            this.lbl_no1.Name = "lbl_no1";
            this.lbl_no1.Size = new System.Drawing.Size(108, 23);
            this.lbl_no1.TabIndex = 18;
            this.lbl_no1.Text = "1st NUMBER:";
            // 
            // box_no2
            // 
            this.box_no2.Location = new System.Drawing.Point(290, 88);
            this.box_no2.Name = "box_no2";
            this.box_no2.Size = new System.Drawing.Size(71, 22);
            this.box_no2.TabIndex = 21;
            // 
            // lbl_no2
            // 
            this.lbl_no2.AutoSize = true;
            this.lbl_no2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no2.Location = new System.Drawing.Point(123, 88);
            this.lbl_no2.Name = "lbl_no2";
            this.lbl_no2.Size = new System.Drawing.Size(120, 23);
            this.lbl_no2.TabIndex = 20;
            this.lbl_no2.Text = "2nd NUMBER:";
            // 
            // btn_substract
            // 
            this.btn_substract.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_substract.Location = new System.Drawing.Point(216, 149);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(75, 54);
            this.btn_substract.TabIndex = 22;
            this.btn_substract.Text = "*";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 23;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(304, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 54);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(154, 281);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 54);
            this.btn_divide.TabIndex = 25;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_remainder
            // 
            this.btn_remainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remainder.Location = new System.Drawing.Point(286, 281);
            this.btn_remainder.Name = "btn_remainder";
            this.btn_remainder.Size = new System.Drawing.Size(75, 54);
            this.btn_remainder.TabIndex = 26;
            this.btn_remainder.Text = "%";
            this.btn_remainder.UseVisualStyleBackColor = true;
            this.btn_remainder.Click += new System.EventHandler(this.btn_remainder_Click);
            // 
            // box_answer
            // 
            this.box_answer.Location = new System.Drawing.Point(269, 388);
            this.box_answer.Name = "box_answer";
            this.box_answer.Size = new System.Drawing.Size(71, 22);
            this.box_answer.TabIndex = 28;
            // 
            // lbl_ans
            // 
            this.lbl_ans.AutoSize = true;
            this.lbl_ans.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ans.Location = new System.Drawing.Point(160, 387);
            this.lbl_ans.Name = "lbl_ans";
            this.lbl_ans.Size = new System.Drawing.Size(88, 23);
            this.lbl_ans.TabIndex = 27;
            this.lbl_ans.Text = "ANSWER:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_back.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 414);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 34);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForm1_Canlong.Properties.Resources.technology_background__digital_hand__simple_background_with_co;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 486);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 469);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.box_answer);
            this.Controls.Add(this.lbl_ans);
            this.Controls.Add(this.btn_remainder);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_substract);
            this.Controls.Add(this.box_no2);
            this.Controls.Add(this.lbl_no2);
            this.Controls.Add(this.box_no1);
            this.Controls.Add(this.lbl_no1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_no1;
        private System.Windows.Forms.Label lbl_no1;
        private System.Windows.Forms.TextBox box_no2;
        private System.Windows.Forms.Label lbl_no2;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_remainder;
        private System.Windows.Forms.TextBox box_answer;
        private System.Windows.Forms.Label lbl_ans;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}