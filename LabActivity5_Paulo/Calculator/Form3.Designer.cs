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
            this.BtnInt = new System.Windows.Forms.Button();
            this.BtnFloat = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.LblFirstNumber = new System.Windows.Forms.Label();
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.LblSecondNumber = new System.Windows.Forms.Label();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInt
            // 
            this.BtnInt.Location = new System.Drawing.Point(23, 52);
            this.BtnInt.Name = "BtnInt";
            this.BtnInt.Size = new System.Drawing.Size(155, 27);
            this.BtnInt.TabIndex = 0;
            this.BtnInt.Text = "Integer";
            this.BtnInt.UseVisualStyleBackColor = true;
            this.BtnInt.Click += new System.EventHandler(this.BtnInt_Click);
            // 
            // BtnFloat
            // 
            this.BtnFloat.Location = new System.Drawing.Point(194, 52);
            this.BtnFloat.Name = "BtnFloat";
            this.BtnFloat.Size = new System.Drawing.Size(155, 27);
            this.BtnFloat.TabIndex = 1;
            this.BtnFloat.Text = "Float";
            this.BtnFloat.UseVisualStyleBackColor = true;
            this.BtnFloat.Click += new System.EventHandler(this.BtnFloat_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(368, 52);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(155, 27);
            this.BtnDouble.TabIndex = 2;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // LblFirstNumber
            // 
            this.LblFirstNumber.AutoSize = true;
            this.LblFirstNumber.Location = new System.Drawing.Point(31, 130);
            this.LblFirstNumber.Name = "LblFirstNumber";
            this.LblFirstNumber.Size = new System.Drawing.Size(97, 13);
            this.LblFirstNumber.TabIndex = 3;
            this.LblFirstNumber.Text = "Enter First Number:";
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(135, 130);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(100, 20);
            this.tbFirstNumber.TabIndex = 4;
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(385, 127);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(100, 20);
            this.tbSecondNumber.TabIndex = 6;
            this.tbSecondNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LblSecondNumber
            // 
            this.LblSecondNumber.AutoSize = true;
            this.LblSecondNumber.Location = new System.Drawing.Point(264, 130);
            this.LblSecondNumber.Name = "LblSecondNumber";
            this.LblSecondNumber.Size = new System.Drawing.Size(115, 13);
            this.LblSecondNumber.TabIndex = 5;
            this.LblSecondNumber.Text = "Enter Second Number:";
            this.LblSecondNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(205, 188);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(134, 43);
            this.BtnSum.TabIndex = 7;
            this.BtnSum.Text = "Compute Sum";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(462, 211);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(76, 39);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.LblSecondNumber);
            this.Controls.Add(this.tbFirstNumber);
            this.Controls.Add(this.LblFirstNumber);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtnFloat);
            this.Controls.Add(this.BtnInt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInt;
        private System.Windows.Forms.Button BtnFloat;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.Label LblFirstNumber;
        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.Label LblSecondNumber;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnExit;
    }
}