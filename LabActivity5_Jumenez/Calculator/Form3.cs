using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            int number = 25;
            MessageBox.Show(number.ToString());
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float number = 25.78F;
            MessageBox.Show(number.ToString());
       
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double number = 25.7889;
            MessageBox.Show(number.ToString());
        }

        private void btnComputeSum_Click(object sender, EventArgs e)
        {
            int FirstTextBoxNumber, SecondTextBoxNumber, sum;

            FirstTextBoxNumber = int.Parse(FrstTxtBoxNum.Text);
            SecondTextBoxNumber = int.Parse(ScndTxtBoxNum.Text);
            sum = FirstTextBoxNumber + SecondTextBoxNumber;
            MessageBox.Show("Sum is " + sum.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
