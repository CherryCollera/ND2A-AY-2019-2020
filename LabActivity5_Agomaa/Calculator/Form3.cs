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

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            int number = 25;
            MessageBox.Show(number.ToString());
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            float number = 25.78F;
            MessageBox.Show(number.ToString());
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            double number = 25.7889;
            MessageBox.Show(number.ToString());
        }

        private void BtnComputeSum_Click(object sender, EventArgs e)
        {
            int firstTextboxNumber, secondTextboxNumber, sum;

            firstTextboxNumber = int.Parse(tbFNumber.Text);
            secondTextboxNumber = int.Parse(tbSnum.Text);
            sum = firstTextboxNumber + secondTextboxNumber ;
            MessageBox.Show("Sum is " + sum.ToString());

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
