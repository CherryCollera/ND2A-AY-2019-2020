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
            this.btnInt = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblFnum = new System.Windows.Forms.Label();
            this.lblSnum = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(26, 46);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(126, 28);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "Integer";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloat.Location = new System.Drawing.Point(177, 46);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(126, 28);
            this.btnFloat.TabIndex = 1;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(328, 46);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(126, 28);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblFnum
            // 
            this.lblFnum.AutoSize = true;
            this.lblFnum.Location = new System.Drawing.Point(33, 110);
            this.lblFnum.Name = "lblFnum";
            this.lblFnum.Size = new System.Drawing.Size(92, 13);
            this.lblFnum.TabIndex = 3;
            this.lblFnum.Text = "Enter first number:";
            // 
            // lblSnum
            // 
            this.lblSnum.AutoSize = true;
            this.lblSnum.Location = new System.Drawing.Point(246, 110);
            this.lblSnum.Name = "lblSnum";
            this.lblSnum.Size = new System.Drawing.Size(111, 13);
            this.lblSnum.TabIndex = 4;
            this.lblSnum.Text = "Enter second number:";
            this.lblSnum.Click += new System.EventHandler(this.lblSnum_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(131, 107);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(109, 20);
            this.txtBox1.TabIndex = 5;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(363, 107);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(111, 20);
            this.txtBox2.TabIndex = 6;
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(161, 165);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(154, 34);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Compute Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnEx
            // 
            this.btnEx.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.Location = new System.Drawing.Point(380, 197);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(94, 27);
            this.btnEx.TabIndex = 8;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(497, 236);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lblSnum);
            this.Controls.Add(this.lblFnum);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnInt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblFnum;
        private System.Windows.Forms.Label lblSnum;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnEx;
    }
}