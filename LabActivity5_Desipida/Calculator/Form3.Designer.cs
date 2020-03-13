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
            this.Lbl_Firstnum = new System.Windows.Forms.Label();
            this.Txt_Box1 = new System.Windows.Forms.TextBox();
            this.Txt_Box2 = new System.Windows.Forms.TextBox();
            this.Lbl_Secondnum = new System.Windows.Forms.Label();
            this.Btn_ComputeSum = new System.Windows.Forms.Button();
            this.Btn_Ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Integer
            // 
            this.Btn_Integer.BackColor = System.Drawing.Color.Aquamarine;
            this.Btn_Integer.Location = new System.Drawing.Point(58, 92);
            this.Btn_Integer.Name = "Btn_Integer";
            this.Btn_Integer.Size = new System.Drawing.Size(172, 54);
            this.Btn_Integer.TabIndex = 0;
            this.Btn_Integer.Text = "Integer";
            this.Btn_Integer.UseVisualStyleBackColor = false;
            this.Btn_Integer.Click += new System.EventHandler(this.Btn_Integer_Click);
            // 
            // Btn_Float
            // 
            this.Btn_Float.BackColor = System.Drawing.Color.Aquamarine;
            this.Btn_Float.Location = new System.Drawing.Point(335, 92);
            this.Btn_Float.Name = "Btn_Float";
            this.Btn_Float.Size = new System.Drawing.Size(172, 54);
            this.Btn_Float.TabIndex = 1;
            this.Btn_Float.Text = "Float";
            this.Btn_Float.UseVisualStyleBackColor = false;
            this.Btn_Float.Click += new System.EventHandler(this.Btn_Float_Click);
            // 
            // Btn_Double
            // 
            this.Btn_Double.BackColor = System.Drawing.Color.Aquamarine;
            this.Btn_Double.Location = new System.Drawing.Point(623, 92);
            this.Btn_Double.Name = "Btn_Double";
            this.Btn_Double.Size = new System.Drawing.Size(172, 54);
            this.Btn_Double.TabIndex = 2;
            this.Btn_Double.Text = "Double";
            this.Btn_Double.UseVisualStyleBackColor = false;
            this.Btn_Double.Click += new System.EventHandler(this.Btn_Double_Click);
            // 
            // Lbl_Firstnum
            // 
            this.Lbl_Firstnum.AutoSize = true;
            this.Lbl_Firstnum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Firstnum.Location = new System.Drawing.Point(58, 200);
            this.Lbl_Firstnum.Name = "Lbl_Firstnum";
            this.Lbl_Firstnum.Size = new System.Drawing.Size(131, 17);
            this.Lbl_Firstnum.TabIndex = 3;
            this.Lbl_Firstnum.Text = "Enter First Number:";
            // 
            // Txt_Box1
            // 
            this.Txt_Box1.Location = new System.Drawing.Point(196, 200);
            this.Txt_Box1.Name = "Txt_Box1";
            this.Txt_Box1.Size = new System.Drawing.Size(184, 22);
            this.Txt_Box1.TabIndex = 4;
            this.Txt_Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_Box2
            // 
            this.Txt_Box2.Location = new System.Drawing.Point(611, 200);
            this.Txt_Box2.Name = "Txt_Box2";
            this.Txt_Box2.Size = new System.Drawing.Size(184, 22);
            this.Txt_Box2.TabIndex = 6;
            this.Txt_Box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lbl_Secondnum
            // 
            this.Lbl_Secondnum.AutoSize = true;
            this.Lbl_Secondnum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Secondnum.Location = new System.Drawing.Point(453, 203);
            this.Lbl_Secondnum.Name = "Lbl_Secondnum";
            this.Lbl_Secondnum.Size = new System.Drawing.Size(152, 17);
            this.Lbl_Secondnum.TabIndex = 5;
            this.Lbl_Secondnum.Text = "Enter Second Number:";
            this.Lbl_Secondnum.Click += new System.EventHandler(this.Lbl_Secondnum_Click);
            // 
            // Btn_ComputeSum
            // 
            this.Btn_ComputeSum.BackColor = System.Drawing.Color.Aquamarine;
            this.Btn_ComputeSum.Location = new System.Drawing.Point(335, 260);
            this.Btn_ComputeSum.Name = "Btn_ComputeSum";
            this.Btn_ComputeSum.Size = new System.Drawing.Size(172, 50);
            this.Btn_ComputeSum.TabIndex = 7;
            this.Btn_ComputeSum.Text = "Compute Sum";
            this.Btn_ComputeSum.UseVisualStyleBackColor = false;
            this.Btn_ComputeSum.Click += new System.EventHandler(this.Btn_ComputeSum_Click);
            // 
            // Btn_Ext
            // 
            this.Btn_Ext.BackColor = System.Drawing.Color.Aquamarine;
            this.Btn_Ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ext.Location = new System.Drawing.Point(744, 296);
            this.Btn_Ext.Name = "Btn_Ext";
            this.Btn_Ext.Size = new System.Drawing.Size(101, 50);
            this.Btn_Ext.TabIndex = 8;
            this.Btn_Ext.Text = "EXIT";
            this.Btn_Ext.UseVisualStyleBackColor = false;
            this.Btn_Ext.Click += new System.EventHandler(this.Btn_Ext_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(857, 358);
            this.Controls.Add(this.Btn_Ext);
            this.Controls.Add(this.Btn_ComputeSum);
            this.Controls.Add(this.Txt_Box2);
            this.Controls.Add(this.Lbl_Secondnum);
            this.Controls.Add(this.Txt_Box1);
            this.Controls.Add(this.Lbl_Firstnum);
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
        private System.Windows.Forms.Label Lbl_Firstnum;
        private System.Windows.Forms.TextBox Txt_Box1;
        private System.Windows.Forms.TextBox Txt_Box2;
        private System.Windows.Forms.Label Lbl_Secondnum;
        private System.Windows.Forms.Button Btn_ComputeSum;
        private System.Windows.Forms.Button Btn_Ext;
    }
}