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
            this.Btn_Integer = new System.Windows.Forms.Button();
            this.Btn_Float = new System.Windows.Forms.Button();
            this.Btn_Double = new System.Windows.Forms.Button();
            this.lbl_fn = new System.Windows.Forms.Label();
            this.TxtBox_1 = new System.Windows.Forms.TextBox();
            this.lbl_sn = new System.Windows.Forms.Label();
            this.TxtBox_2 = new System.Windows.Forms.TextBox();
            this.Btn_ComputeSum = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Integer
            // 
            this.Btn_Integer.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Integer.Location = new System.Drawing.Point(46, 54);
            this.Btn_Integer.Name = "Btn_Integer";
            this.Btn_Integer.Size = new System.Drawing.Size(154, 25);
            this.Btn_Integer.TabIndex = 0;
            this.Btn_Integer.Text = "Integer";
            this.Btn_Integer.UseVisualStyleBackColor = false;
            this.Btn_Integer.Click += new System.EventHandler(this.Btn_Integer_Click);
            // 
            // Btn_Float
            // 
            this.Btn_Float.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Float.Location = new System.Drawing.Point(240, 54);
            this.Btn_Float.Name = "Btn_Float";
            this.Btn_Float.Size = new System.Drawing.Size(182, 25);
            this.Btn_Float.TabIndex = 1;
            this.Btn_Float.Text = "Float";
            this.Btn_Float.UseVisualStyleBackColor = false;
            this.Btn_Float.Click += new System.EventHandler(this.Btn_Float_Click);
            // 
            // Btn_Double
            // 
            this.Btn_Double.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Double.Location = new System.Drawing.Point(449, 54);
            this.Btn_Double.Name = "Btn_Double";
            this.Btn_Double.Size = new System.Drawing.Size(183, 25);
            this.Btn_Double.TabIndex = 2;
            this.Btn_Double.Text = "Double";
            this.Btn_Double.UseVisualStyleBackColor = false;
            this.Btn_Double.Click += new System.EventHandler(this.Btn_Double_Click);
            // 
            // lbl_fn
            // 
            this.lbl_fn.AutoSize = true;
            this.lbl_fn.Location = new System.Drawing.Point(69, 117);
            this.lbl_fn.Name = "lbl_fn";
            this.lbl_fn.Size = new System.Drawing.Size(95, 13);
            this.lbl_fn.TabIndex = 3;
            this.lbl_fn.Text = "Enter first number: ";
            // 
            // TxtBox_1
            // 
            this.TxtBox_1.Location = new System.Drawing.Point(170, 114);
            this.TxtBox_1.Name = "TxtBox_1";
            this.TxtBox_1.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_1.TabIndex = 4;
            // 
            // lbl_sn
            // 
            this.lbl_sn.AutoSize = true;
            this.lbl_sn.Location = new System.Drawing.Point(364, 117);
            this.lbl_sn.Name = "lbl_sn";
            this.lbl_sn.Size = new System.Drawing.Size(114, 13);
            this.lbl_sn.TabIndex = 5;
            this.lbl_sn.Text = "Enter second number: ";
            // 
            // TxtBox_2
            // 
            this.TxtBox_2.Location = new System.Drawing.Point(479, 114);
            this.TxtBox_2.Name = "TxtBox_2";
            this.TxtBox_2.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_2.TabIndex = 6;
            // 
            // Btn_ComputeSum
            // 
            this.Btn_ComputeSum.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_ComputeSum.Location = new System.Drawing.Point(240, 185);
            this.Btn_ComputeSum.Name = "Btn_ComputeSum";
            this.Btn_ComputeSum.Size = new System.Drawing.Size(182, 25);
            this.Btn_ComputeSum.TabIndex = 7;
            this.Btn_ComputeSum.Text = "Compute Sum";
            this.Btn_ComputeSum.UseVisualStyleBackColor = false;
            this.Btn_ComputeSum.Click += new System.EventHandler(this.Btn_ComputeSum_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_Exit.Location = new System.Drawing.Point(577, 259);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(88, 31);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(677, 302);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_ComputeSum);
            this.Controls.Add(this.TxtBox_2);
            this.Controls.Add(this.lbl_sn);
            this.Controls.Add(this.TxtBox_1);
            this.Controls.Add(this.lbl_fn);
            this.Controls.Add(this.Btn_Double);
            this.Controls.Add(this.Btn_Float);
            this.Controls.Add(this.Btn_Integer);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Integer;
        private System.Windows.Forms.Button Btn_Float;
        private System.Windows.Forms.Button Btn_Double;
        private System.Windows.Forms.Label lbl_fn;
        private System.Windows.Forms.TextBox TxtBox_1;
        private System.Windows.Forms.Label lbl_sn;
        private System.Windows.Forms.TextBox TxtBox_2;
        private System.Windows.Forms.Button Btn_ComputeSum;
        private System.Windows.Forms.Button Btn_Exit;
    }
}