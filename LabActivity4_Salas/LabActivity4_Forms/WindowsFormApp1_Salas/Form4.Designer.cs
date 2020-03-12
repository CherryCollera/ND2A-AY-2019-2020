namespace WindowsFormApp1_Salas
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
            this.fnum = new System.Windows.Forms.Label();
            this.Snum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Prod = new System.Windows.Forms.Button();
            this.quot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnum
            // 
            this.fnum.AutoSize = true;
            this.fnum.Location = new System.Drawing.Point(12, 36);
            this.fnum.Name = "fnum";
            this.fnum.Size = new System.Drawing.Size(69, 13);
            this.fnum.TabIndex = 0;
            this.fnum.Text = "First Number:";
            // 
            // Snum
            // 
            this.Snum.AutoSize = true;
            this.Snum.Location = new System.Drawing.Point(12, 67);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(87, 13);
            this.Snum.TabIndex = 1;
            this.Snum.Text = "Second Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.LightCoral;
            this.plus.ForeColor = System.Drawing.Color.Black;
            this.plus.Location = new System.Drawing.Point(55, 90);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(81, 33);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.LightCoral;
            this.Sub.Location = new System.Drawing.Point(142, 90);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(82, 33);
            this.Sub.TabIndex = 5;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Prod
            // 
            this.Prod.BackColor = System.Drawing.Color.LightCoral;
            this.Prod.Location = new System.Drawing.Point(55, 129);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(81, 33);
            this.Prod.TabIndex = 6;
            this.Prod.Text = "*";
            this.Prod.UseVisualStyleBackColor = false;
            this.Prod.Click += new System.EventHandler(this.Prod_Click);
            // 
            // quot
            // 
            this.quot.BackColor = System.Drawing.Color.LightCoral;
            this.quot.Location = new System.Drawing.Point(142, 129);
            this.quot.Name = "quot";
            this.quot.Size = new System.Drawing.Size(81, 33);
            this.quot.TabIndex = 7;
            this.quot.Text = "/";
            this.quot.UseVisualStyleBackColor = false;
            this.quot.Click += new System.EventHandler(this.quot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Answer:";
            // 
            // textAnswer
            // 
            this.textAnswer.Location = new System.Drawing.Point(87, 211);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(100, 20);
            this.textAnswer.TabIndex = 9;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightCoral;
            this.Back.Location = new System.Drawing.Point(186, 244);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // modulo
            // 
            this.modulo.BackColor = System.Drawing.Color.LightCoral;
            this.modulo.Location = new System.Drawing.Point(96, 168);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(81, 33);
            this.modulo.TabIndex = 11;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = false;
            this.modulo.Click += new System.EventHandler(this.modulo_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quot);
            this.Controls.Add(this.Prod);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Snum);
            this.Controls.Add(this.fnum);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnum;
        private System.Windows.Forms.Label Snum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Prod;
        private System.Windows.Forms.Button quot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button modulo;
    }
}