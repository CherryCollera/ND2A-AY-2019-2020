namespace Calculator
{
    partial class Calculator
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
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Btn_GotoForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDisplay
            // 
            this.textDisplay.Location = new System.Drawing.Point(24, 31);
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(256, 22);
            this.textDisplay.TabIndex = 0;
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisplay.TextChanged += new System.EventHandler(this.textDisplay_TextChanged);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Silver;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(24, 59);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(61, 50);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Silver;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(91, 171);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(59, 50);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Silver;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(91, 59);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(59, 50);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Silver;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(156, 59);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(59, 50);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Silver;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(24, 115);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(61, 50);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Silver;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(91, 115);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(59, 50);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Silver;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(156, 115);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(59, 50);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Silver;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(24, 171);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(61, 50);
            this.btnZero.TabIndex = 8;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Silver;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(24, 230);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(61, 50);
            this.btnSeven.TabIndex = 9;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Silver;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(156, 171);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(59, 50);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.Cyan;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(91, 230);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(61, 50);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(158, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 50);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Crimson;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(221, 59);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(59, 50);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // SubBtn
            // 
            this.SubBtn.BackColor = System.Drawing.Color.Crimson;
            this.SubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtn.Location = new System.Drawing.Point(221, 115);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(59, 50);
            this.SubBtn.TabIndex = 14;
            this.SubBtn.Text = "-";
            this.SubBtn.UseVisualStyleBackColor = false;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.BackColor = System.Drawing.Color.Crimson;
            this.MultiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyBtn.Location = new System.Drawing.Point(221, 171);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(59, 50);
            this.MultiplyBtn.TabIndex = 15;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = false;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.BackColor = System.Drawing.Color.Crimson;
            this.DivideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideBtn.Location = new System.Drawing.Point(221, 232);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(59, 50);
            this.DivideBtn.TabIndex = 16;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = false;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(221, 286);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(59, 50);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(24, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 60);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back to form 1";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Btn_GotoForm3
            // 
            this.Btn_GotoForm3.BackColor = System.Drawing.Color.Gold;
            this.Btn_GotoForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GotoForm3.Location = new System.Drawing.Point(125, 286);
            this.Btn_GotoForm3.Name = "Btn_GotoForm3";
            this.Btn_GotoForm3.Size = new System.Drawing.Size(90, 60);
            this.Btn_GotoForm3.TabIndex = 19;
            this.Btn_GotoForm3.Text = "Go to Form 3";
            this.Btn_GotoForm3.UseVisualStyleBackColor = false;
            this.Btn_GotoForm3.Click += new System.EventHandler(this.Btn_GotoForm3_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(301, 374);
            this.Controls.Add(this.Btn_GotoForm3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.textDisplay);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button Btn_GotoForm3;
    }
}

