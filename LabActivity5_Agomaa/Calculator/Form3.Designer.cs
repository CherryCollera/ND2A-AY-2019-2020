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
            this.LblFirstNumber = new System.Windows.Forms.Label();
            this.LblSecondNumber = new System.Windows.Forms.Label();
            this.tbSnum = new System.Windows.Forms.TextBox();
            this.tbFNumber = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInteger
            // 
            this.BtnInteger.Location = new System.Drawing.Point(27, 37);
            this.BtnInteger.Name = "BtnInteger";
            this.BtnInteger.Size = new System.Drawing.Size(139, 29);
            this.BtnInteger.TabIndex = 0;
            this.BtnInteger.Text = "Integer";
            this.BtnInteger.UseVisualStyleBackColor = true;
            this.BtnInteger.Click += new System.EventHandler(this.BtnInteger_Click);
            // 
            // BtnFloat
            // 
            this.BtnFloat.Location = new System.Drawing.Point(186, 37);
            this.BtnFloat.Name = "BtnFloat";
            this.BtnFloat.Size = new System.Drawing.Size(127, 29);
            this.BtnFloat.TabIndex = 1;
            this.BtnFloat.Text = "Float";
            this.BtnFloat.UseVisualStyleBackColor = true;
            this.BtnFloat.Click += new System.EventHandler(this.BtnFloat_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(328, 37);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(137, 29);
            this.BtnDouble.TabIndex = 2;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // BtnComputeSum
            // 
            this.BtnComputeSum.Location = new System.Drawing.Point(186, 196);
            this.BtnComputeSum.Name = "BtnComputeSum";
            this.BtnComputeSum.Size = new System.Drawing.Size(127, 41);
            this.BtnComputeSum.TabIndex = 3;
            this.BtnComputeSum.Text = "Compute Sum";
            this.BtnComputeSum.UseVisualStyleBackColor = true;
            this.BtnComputeSum.Click += new System.EventHandler(this.BtnComputeSum_Click);
            // 
            // LblFirstNumber
            // 
            this.LblFirstNumber.AutoSize = true;
            this.LblFirstNumber.Location = new System.Drawing.Point(42, 120);
            this.LblFirstNumber.Name = "LblFirstNumber";
            this.LblFirstNumber.Size = new System.Drawing.Size(92, 13);
            this.LblFirstNumber.TabIndex = 4;
            this.LblFirstNumber.Text = "Enter first number:";
            // 
            // LblSecondNumber
            // 
            this.LblSecondNumber.AutoSize = true;
            this.LblSecondNumber.Location = new System.Drawing.Point(258, 120);
            this.LblSecondNumber.Name = "LblSecondNumber";
            this.LblSecondNumber.Size = new System.Drawing.Size(111, 13);
            this.LblSecondNumber.TabIndex = 5;
            this.LblSecondNumber.Text = "Enter second number:";
            // 
            // tbSnum
            // 
            this.tbSnum.Location = new System.Drawing.Point(375, 117);
            this.tbSnum.Name = "tbSnum";
            this.tbSnum.Size = new System.Drawing.Size(100, 20);
            this.tbSnum.TabIndex = 6;
            // 
            // tbFNumber
            // 
            this.tbFNumber.Location = new System.Drawing.Point(140, 117);
            this.tbFNumber.Name = "tbFNumber";
            this.tbFNumber.Size = new System.Drawing.Size(100, 20);
            this.tbFNumber.TabIndex = 7;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(390, 214);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 299);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.tbFNumber);
            this.Controls.Add(this.tbSnum);
            this.Controls.Add(this.LblSecondNumber);
            this.Controls.Add(this.LblFirstNumber);
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
        private System.Windows.Forms.Label LblFirstNumber;
        private System.Windows.Forms.Label LblSecondNumber;
        private System.Windows.Forms.TextBox tbSnum;
        private System.Windows.Forms.TextBox tbFNumber;
        private System.Windows.Forms.Button BtnExit;
    }
}