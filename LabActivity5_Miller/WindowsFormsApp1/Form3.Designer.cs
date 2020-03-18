namespace WindowsFormsApp1
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
            this.Btn_int = new System.Windows.Forms.Button();
            this.Btn_float = new System.Windows.Forms.Button();
            this.Btn_Double = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_1st = new System.Windows.Forms.TextBox();
            this.Txt_2nd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_compute = new System.Windows.Forms.Button();
            this.Btn_Ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_int
            // 
            this.Btn_int.Location = new System.Drawing.Point(57, 57);
            this.Btn_int.Name = "Btn_int";
            this.Btn_int.Size = new System.Drawing.Size(176, 59);
            this.Btn_int.TabIndex = 0;
            this.Btn_int.Text = "Integer";
            this.Btn_int.UseVisualStyleBackColor = true;
            this.Btn_int.Click += new System.EventHandler(this.Btn_int_Click);
            // 
            // Btn_float
            // 
            this.Btn_float.Location = new System.Drawing.Point(400, 57);
            this.Btn_float.Name = "Btn_float";
            this.Btn_float.Size = new System.Drawing.Size(176, 59);
            this.Btn_float.TabIndex = 1;
            this.Btn_float.Text = "Float";
            this.Btn_float.UseVisualStyleBackColor = true;
            this.Btn_float.Click += new System.EventHandler(this.Btn_float_Click);
            // 
            // Btn_Double
            // 
            this.Btn_Double.Location = new System.Drawing.Point(734, 57);
            this.Btn_Double.Name = "Btn_Double";
            this.Btn_Double.Size = new System.Drawing.Size(176, 59);
            this.Btn_Double.TabIndex = 2;
            this.Btn_Double.Text = "Double";
            this.Btn_Double.UseVisualStyleBackColor = true;
            this.Btn_Double.Click += new System.EventHandler(this.Btn_Double_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter 1st Number";
            // 
            // Txt_1st
            // 
            this.Txt_1st.Location = new System.Drawing.Point(198, 203);
            this.Txt_1st.Name = "Txt_1st";
            this.Txt_1st.Size = new System.Drawing.Size(203, 26);
            this.Txt_1st.TabIndex = 4;
            // 
            // Txt_2nd
            // 
            this.Txt_2nd.Location = new System.Drawing.Point(634, 203);
            this.Txt_2nd.Name = "Txt_2nd";
            this.Txt_2nd.Size = new System.Drawing.Size(203, 26);
            this.Txt_2nd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter 2nd Number";
            // 
            // Btn_compute
            // 
            this.Btn_compute.Location = new System.Drawing.Point(400, 306);
            this.Btn_compute.Name = "Btn_compute";
            this.Btn_compute.Size = new System.Drawing.Size(176, 59);
            this.Btn_compute.TabIndex = 7;
            this.Btn_compute.Text = "Compute Sum";
            this.Btn_compute.UseVisualStyleBackColor = true;
            this.Btn_compute.Click += new System.EventHandler(this.Btn_compute_Click);
            // 
            // Btn_Ext
            // 
            this.Btn_Ext.Location = new System.Drawing.Point(768, 343);
            this.Btn_Ext.Name = "Btn_Ext";
            this.Btn_Ext.Size = new System.Drawing.Size(176, 59);
            this.Btn_Ext.TabIndex = 8;
            this.Btn_Ext.Text = "Exit";
            this.Btn_Ext.UseVisualStyleBackColor = true;
            this.Btn_Ext.Click += new System.EventHandler(this.Btn_Ext_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 414);
            this.Controls.Add(this.Btn_Ext);
            this.Controls.Add(this.Btn_compute);
            this.Controls.Add(this.Txt_2nd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_1st);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Double);
            this.Controls.Add(this.Btn_float);
            this.Controls.Add(this.Btn_int);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_int;
        private System.Windows.Forms.Button Btn_float;
        private System.Windows.Forms.Button Btn_Double;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_1st;
        private System.Windows.Forms.TextBox Txt_2nd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_compute;
        private System.Windows.Forms.Button Btn_Ext;
    }
}