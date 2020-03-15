namespace Calculator_Canlong
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
            this.Btn_Int = new System.Windows.Forms.Button();
            this.Btn_Float = new System.Windows.Forms.Button();
            this.Btn_Double = new System.Windows.Forms.Button();
            this.Label_1st = new System.Windows.Forms.Label();
            this.Txt_First = new System.Windows.Forms.TextBox();
            this.Txt_Second = new System.Windows.Forms.TextBox();
            this.Label_2nd = new System.Windows.Forms.Label();
            this.Btn_CSum = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Int
            // 
            this.Btn_Int.Location = new System.Drawing.Point(47, 88);
            this.Btn_Int.Name = "Btn_Int";
            this.Btn_Int.Size = new System.Drawing.Size(194, 47);
            this.Btn_Int.TabIndex = 0;
            this.Btn_Int.Text = "Integer";
            this.Btn_Int.UseVisualStyleBackColor = true;
            this.Btn_Int.Click += new System.EventHandler(this.Btn_Int_Click);
            // 
            // Btn_Float
            // 
            this.Btn_Float.Location = new System.Drawing.Point(260, 88);
            this.Btn_Float.Name = "Btn_Float";
            this.Btn_Float.Size = new System.Drawing.Size(194, 47);
            this.Btn_Float.TabIndex = 1;
            this.Btn_Float.Text = "Float";
            this.Btn_Float.UseVisualStyleBackColor = true;
            this.Btn_Float.Click += new System.EventHandler(this.Btn_Float_Click);
            // 
            // Btn_Double
            // 
            this.Btn_Double.Location = new System.Drawing.Point(475, 88);
            this.Btn_Double.Name = "Btn_Double";
            this.Btn_Double.Size = new System.Drawing.Size(194, 47);
            this.Btn_Double.TabIndex = 2;
            this.Btn_Double.Text = "Double";
            this.Btn_Double.UseVisualStyleBackColor = true;
            this.Btn_Double.Click += new System.EventHandler(this.Btn_Double_Click);
            // 
            // Label_1st
            // 
            this.Label_1st.AutoSize = true;
            this.Label_1st.Location = new System.Drawing.Point(44, 208);
            this.Label_1st.Name = "Label_1st";
            this.Label_1st.Size = new System.Drawing.Size(143, 17);
            this.Label_1st.TabIndex = 3;
            this.Label_1st.Text = "Enter FIRST Number:";
            // 
            // Txt_First
            // 
            this.Txt_First.Location = new System.Drawing.Point(194, 208);
            this.Txt_First.Name = "Txt_First";
            this.Txt_First.Size = new System.Drawing.Size(126, 22);
            this.Txt_First.TabIndex = 4;
            // 
            // Txt_Second
            // 
            this.Txt_Second.Location = new System.Drawing.Point(517, 211);
            this.Txt_Second.Name = "Txt_Second";
            this.Txt_Second.Size = new System.Drawing.Size(126, 22);
            this.Txt_Second.TabIndex = 6;
            // 
            // Label_2nd
            // 
            this.Label_2nd.AutoSize = true;
            this.Label_2nd.Location = new System.Drawing.Point(349, 211);
            this.Label_2nd.Name = "Label_2nd";
            this.Label_2nd.Size = new System.Drawing.Size(162, 17);
            this.Label_2nd.TabIndex = 5;
            this.Label_2nd.Text = "Enter SECOND Number:";
            // 
            // Btn_CSum
            // 
            this.Btn_CSum.Location = new System.Drawing.Point(260, 285);
            this.Btn_CSum.Name = "Btn_CSum";
            this.Btn_CSum.Size = new System.Drawing.Size(194, 47);
            this.Btn_CSum.TabIndex = 7;
            this.Btn_CSum.Text = "Compute SUM";
            this.Btn_CSum.UseVisualStyleBackColor = true;
            this.Btn_CSum.Click += new System.EventHandler(this.Btn_CSum_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(615, 359);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(91, 47);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(718, 418);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_CSum);
            this.Controls.Add(this.Txt_Second);
            this.Controls.Add(this.Label_2nd);
            this.Controls.Add(this.Txt_First);
            this.Controls.Add(this.Label_1st);
            this.Controls.Add(this.Btn_Double);
            this.Controls.Add(this.Btn_Float);
            this.Controls.Add(this.Btn_Int);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Int;
        private System.Windows.Forms.Button Btn_Float;
        private System.Windows.Forms.Button Btn_Double;
        private System.Windows.Forms.Label Label_1st;
        private System.Windows.Forms.TextBox Txt_First;
        private System.Windows.Forms.TextBox Txt_Second;
        private System.Windows.Forms.Label Label_2nd;
        private System.Windows.Forms.Button Btn_CSum;
        private System.Windows.Forms.Button Btn_Exit;
    }
}