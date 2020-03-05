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
            this.BtnInteger = new System.Windows.Forms.Button();
            this.BtnFloat = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.BtnComputeSum = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Form3Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInteger
            // 
            this.BtnInteger.Location = new System.Drawing.Point(100, 50);
            this.BtnInteger.Name = "BtnInteger";
            this.BtnInteger.Size = new System.Drawing.Size(90, 35);
            this.BtnInteger.TabIndex = 0;
            this.BtnInteger.Text = "Integer";
            this.BtnInteger.UseVisualStyleBackColor = true;
            this.BtnInteger.Click += new System.EventHandler(this.BtnInteger_Click);
            // 
            // BtnFloat
            // 
            this.BtnFloat.Location = new System.Drawing.Point(335, 50);
            this.BtnFloat.Name = "BtnFloat";
            this.BtnFloat.Size = new System.Drawing.Size(90, 35);
            this.BtnFloat.TabIndex = 1;
            this.BtnFloat.Text = "Float";
            this.BtnFloat.UseVisualStyleBackColor = true;
            this.BtnFloat.Click += new System.EventHandler(this.BtnFloat_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(560, 50);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(90, 35);
            this.BtnDouble.TabIndex = 2;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // BtnComputeSum
            // 
            this.BtnComputeSum.Location = new System.Drawing.Point(310, 355);
            this.BtnComputeSum.Name = "BtnComputeSum";
            this.BtnComputeSum.Size = new System.Drawing.Size(150, 35);
            this.BtnComputeSum.TabIndex = 3;
            this.BtnComputeSum.Text = "Compute Sum";
            this.BtnComputeSum.UseVisualStyleBackColor = true;
            this.BtnComputeSum.Click += new System.EventHandler(this.BtnComputeSum_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Second Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form3Exit
            // 
            this.Form3Exit.Location = new System.Drawing.Point(12, 408);
            this.Form3Exit.Name = "Form3Exit";
            this.Form3Exit.Size = new System.Drawing.Size(120, 30);
            this.Form3Exit.TabIndex = 8;
            this.Form3Exit.Text = "Form 3 Exit";
            this.Form3Exit.UseVisualStyleBackColor = true;
            this.Form3Exit.Click += new System.EventHandler(this.Form3Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form3Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnComputeSum);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtnFloat);
            this.Controls.Add(this.BtnInteger);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInteger;
        private System.Windows.Forms.Button BtnFloat;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.Button BtnComputeSum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Form3Exit;
    }
}