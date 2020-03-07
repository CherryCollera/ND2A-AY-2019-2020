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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnComputeSum_Click(object sender, EventArgs e)
        {
            int label1, label2, sum;

            label1 = int.Parse(textBox1.Text);
            label2 = int.Parse(textBox2.Text);
            sum = label1 + label2;
            MessageBox.Show("Sum is " + sum.ToString());
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

        private void Form3Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
