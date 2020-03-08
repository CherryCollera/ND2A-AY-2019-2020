namespace Calculator
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
            this.Btn1_int = new System.Windows.Forms.Button();
            this.Btn2_fl = new System.Windows.Forms.Button();
            this.Btn3_dou = new System.Windows.Forms.Button();
            this.Btn4_coms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btnex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1_int
            // 
            this.Btn1_int.Location = new System.Drawing.Point(61, 45);
            this.Btn1_int.Name = "Btn1_int";
            this.Btn1_int.Size = new System.Drawing.Size(137, 22);
            this.Btn1_int.TabIndex = 0;
            this.Btn1_int.Text = "Integer";
            this.Btn1_int.UseVisualStyleBackColor = true;
            this.Btn1_int.Click += new System.EventHandler(this.Btn1_int_Click);
            // 
            // Btn2_fl
            // 
            this.Btn2_fl.Location = new System.Drawing.Point(279, 45);
            this.Btn2_fl.Name = "Btn2_fl";
            this.Btn2_fl.Size = new System.Drawing.Size(132, 23);
            this.Btn2_fl.TabIndex = 1;
            this.Btn2_fl.Text = "Float";
            this.Btn2_fl.UseVisualStyleBackColor = true;
            this.Btn2_fl.Click += new System.EventHandler(this.Btn2_fl_Click);
            // 
            // Btn3_dou
            // 
            this.Btn3_dou.Location = new System.Drawing.Point(496, 45);
            this.Btn3_dou.Name = "Btn3_dou";
            this.Btn3_dou.Size = new System.Drawing.Size(147, 23);
            this.Btn3_dou.TabIndex = 2;
            this.Btn3_dou.Text = "Double";
            this.Btn3_dou.UseVisualStyleBackColor = true;
            this.Btn3_dou.Click += new System.EventHandler(this.Btn3_dou_Click);
            // 
            // Btn4_coms
            // 
            this.Btn4_coms.Location = new System.Drawing.Point(257, 240);
            this.Btn4_coms.Name = "Btn4_coms";
            this.Btn4_coms.Size = new System.Drawing.Size(141, 34);
            this.Btn4_coms.TabIndex = 3;
            this.Btn4_coms.Text = "Compute Sum";
            this.Btn4_coms.UseVisualStyleBackColor = true;
            this.Btn4_coms.Click += new System.EventHandler(this.Btn4_coms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter First Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Second Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(522, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Btnex
            // 
            this.Btnex.Location = new System.Drawing.Point(568, 272);
            this.Btnex.Name = "Btnex";
            this.Btnex.Size = new System.Drawing.Size(75, 23);
            this.Btnex.TabIndex = 8;
            this.Btnex.Text = "Exit";
            this.Btnex.UseVisualStyleBackColor = true;
            this.Btnex.Click += new System.EventHandler(this.Btnex_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 307);
            this.Controls.Add(this.Btnex);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn4_coms);
            this.Controls.Add(this.Btn3_dou);
            this.Controls.Add(this.Btn2_fl);
            this.Controls.Add(this.Btn1_int);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1_int;
        private System.Windows.Forms.Button Btn2_fl;
        private System.Windows.Forms.Button Btn3_dou;
        private System.Windows.Forms.Button Btn4_coms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btnex;
    }
}