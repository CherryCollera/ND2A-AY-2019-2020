namespace GreetMe
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
            this.lbl_SNum = new System.Windows.Forms.Label();
            this.lbl_Fnum = new System.Windows.Forms.Label();
            this.txtBox_SNum = new System.Windows.Forms.TextBox();
            this.txtBox_Fnum = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.btn_Modulo = new System.Windows.Forms.Button();
            this.lbl_Ans = new System.Windows.Forms.Label();
            this.txtBox_Ans = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SNum
            // 
            this.lbl_SNum.AutoSize = true;
            this.lbl_SNum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SNum.Location = new System.Drawing.Point(12, 67);
            this.lbl_SNum.Name = "lbl_SNum";
            this.lbl_SNum.Size = new System.Drawing.Size(142, 18);
            this.lbl_SNum.TabIndex = 11;
            this.lbl_SNum.Text = "Enter Second Number:";
            // 
            // lbl_Fnum
            // 
            this.lbl_Fnum.AutoSize = true;
            this.lbl_Fnum.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fnum.Location = new System.Drawing.Point(12, 39);
            this.lbl_Fnum.Name = "lbl_Fnum";
            this.lbl_Fnum.Size = new System.Drawing.Size(118, 17);
            this.lbl_Fnum.TabIndex = 10;
            this.lbl_Fnum.Text = "Enter First Number:";
            // 
            // txtBox_SNum
            // 
            this.txtBox_SNum.Location = new System.Drawing.Point(157, 65);
            this.txtBox_SNum.Name = "txtBox_SNum";
            this.txtBox_SNum.Size = new System.Drawing.Size(119, 20);
            this.txtBox_SNum.TabIndex = 9;
            // 
            // txtBox_Fnum
            // 
            this.txtBox_Fnum.Location = new System.Drawing.Point(157, 38);
            this.txtBox_Fnum.Name = "txtBox_Fnum";
            this.txtBox_Fnum.Size = new System.Drawing.Size(119, 20);
            this.txtBox_Fnum.TabIndex = 8;
            this.txtBox_Fnum.TextChanged += new System.EventHandler(this.txtBox_Fnum_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Yellow;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(38, 119);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(104, 28);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.Yellow;
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minus.Location = new System.Drawing.Point(170, 119);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(106, 28);
            this.btn_Minus.TabIndex = 13;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.BackColor = System.Drawing.Color.Yellow;
            this.btn_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiply.Location = new System.Drawing.Point(38, 165);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(104, 28);
            this.btn_Multiply.TabIndex = 14;
            this.btn_Multiply.Text = "*";
            this.btn_Multiply.UseVisualStyleBackColor = false;
            this.btn_Multiply.Click += new System.EventHandler(this.btn_Multiply_Click);
            // 
            // btn_Divide
            // 
            this.btn_Divide.BackColor = System.Drawing.Color.Yellow;
            this.btn_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Divide.Location = new System.Drawing.Point(170, 165);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(106, 28);
            this.btn_Divide.TabIndex = 15;
            this.btn_Divide.Text = "/";
            this.btn_Divide.UseVisualStyleBackColor = false;
            this.btn_Divide.Click += new System.EventHandler(this.btn_Divide_Click);
            // 
            // btn_Modulo
            // 
            this.btn_Modulo.BackColor = System.Drawing.Color.Yellow;
            this.btn_Modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modulo.Location = new System.Drawing.Point(106, 199);
            this.btn_Modulo.Name = "btn_Modulo";
            this.btn_Modulo.Size = new System.Drawing.Size(101, 28);
            this.btn_Modulo.TabIndex = 16;
            this.btn_Modulo.Text = "%";
            this.btn_Modulo.UseVisualStyleBackColor = false;
            this.btn_Modulo.Click += new System.EventHandler(this.btn_Modulo_Click);
            // 
            // lbl_Ans
            // 
            this.lbl_Ans.AutoSize = true;
            this.lbl_Ans.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ans.Location = new System.Drawing.Point(50, 244);
            this.lbl_Ans.Name = "lbl_Ans";
            this.lbl_Ans.Size = new System.Drawing.Size(82, 26);
            this.lbl_Ans.TabIndex = 18;
            this.lbl_Ans.Text = "Answer:";
            this.lbl_Ans.Click += new System.EventHandler(this.lbl_Ans_Click);
            // 
            // txtBox_Ans
            // 
            this.txtBox_Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Ans.Location = new System.Drawing.Point(157, 244);
            this.txtBox_Ans.Name = "txtBox_Ans";
            this.txtBox_Ans.Size = new System.Drawing.Size(119, 22);
            this.txtBox_Ans.TabIndex = 17;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Back.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(106, 282);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(90, 31);
            this.btn_Back.TabIndex = 19;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "My Calculator";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(308, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Ans);
            this.Controls.Add(this.txtBox_Ans);
            this.Controls.Add(this.btn_Modulo);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_SNum);
            this.Controls.Add(this.lbl_Fnum);
            this.Controls.Add(this.txtBox_SNum);
            this.Controls.Add(this.txtBox_Fnum);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SNum;
        private System.Windows.Forms.Label lbl_Fnum;
        private System.Windows.Forms.TextBox txtBox_SNum;
        private System.Windows.Forms.TextBox txtBox_Fnum;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Modulo;
        private System.Windows.Forms.Label lbl_Ans;
        private System.Windows.Forms.TextBox txtBox_Ans;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
    }
}