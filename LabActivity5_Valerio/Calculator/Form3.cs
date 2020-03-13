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

        private void lblSnum_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInt_Click(object sender, EventArgs e)
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

        private void btnSum_Click(object sender, EventArgs e)
        {
            int txtBoxOne, txtBoxTwo, sum;

            txtBoxOne = int.Parse(txtBox1.Text);
            txtBoxTwo = int.Parse(txtBox2.Text);
            sum = txtBoxOne + txtBoxTwo;
            MessageBox.Show("Sum is " + sum.ToString());
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
