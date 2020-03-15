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
            this.btnInteger = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnf1 = new System.Windows.Forms.Label();
            this.btns2 = new System.Windows.Forms.Label();
            this.btnComputeSum = new System.Windows.Forms.Button();
            this.FrstTxtBoxNum = new System.Windows.Forms.TextBox();
            this.ScndTxtBoxNum = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInteger
            // 
            this.btnInteger.Location = new System.Drawing.Point(39, 39);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(119, 34);
            this.btnInteger.TabIndex = 0;
            this.btnInteger.Text = "Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(195, 39);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(120, 34);
            this.btnFloat.TabIndex = 1;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(358, 39);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(122, 34);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnf1
            // 
            this.btnf1.AutoSize = true;
            this.btnf1.Location = new System.Drawing.Point(36, 124);
            this.btnf1.Name = "btnf1";
            this.btnf1.Size = new System.Drawing.Size(97, 13);
            this.btnf1.TabIndex = 3;
            this.btnf1.Text = "Enter First Number:";
            // 
            // btns2
            // 
            this.btns2.AutoSize = true;
            this.btns2.Location = new System.Drawing.Point(259, 124);
            this.btns2.Name = "btns2";
            this.btns2.Size = new System.Drawing.Size(115, 13);
            this.btns2.TabIndex = 4;
            this.btns2.Text = "Enter Second Number:";
            // 
            // btnComputeSum
            // 
            this.btnComputeSum.Location = new System.Drawing.Point(200, 189);
            this.btnComputeSum.Name = "btnComputeSum";
            this.btnComputeSum.Size = new System.Drawing.Size(115, 35);
            this.btnComputeSum.TabIndex = 5;
            this.btnComputeSum.Text = "Compute Sum";
            this.btnComputeSum.UseVisualStyleBackColor = true;
            this.btnComputeSum.Click += new System.EventHandler(this.btnComputeSum_Click);
            // 
            // FrstTxtBoxNum
            // 
            this.FrstTxtBoxNum.Location = new System.Drawing.Point(139, 121);
            this.FrstTxtBoxNum.Name = "FrstTxtBoxNum";
            this.FrstTxtBoxNum.Size = new System.Drawing.Size(100, 20);
            this.FrstTxtBoxNum.TabIndex = 6;
            // 
            // ScndTxtBoxNum
            // 
            this.ScndTxtBoxNum.Location = new System.Drawing.Point(380, 124);
            this.ScndTxtBoxNum.Name = "ScndTxtBoxNum";
            this.ScndTxtBoxNum.Size = new System.Drawing.Size(100, 20);
            this.ScndTxtBoxNum.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(227, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ScndTxtBoxNum);
            this.Controls.Add(this.FrstTxtBoxNum);
            this.Controls.Add(this.btnComputeSum);
            this.Controls.Add(this.btns2);
            this.Controls.Add(this.btnf1);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnInteger);
            this.Name = "Form3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label btnf1;
        private System.Windows.Forms.Label btns2;
        private System.Windows.Forms.Button btnComputeSum;
        private System.Windows.Forms.TextBox FrstTxtBoxNum;
        private System.Windows.Forms.TextBox ScndTxtBoxNum;
        private System.Windows.Forms.Button btnExit;
    }
}