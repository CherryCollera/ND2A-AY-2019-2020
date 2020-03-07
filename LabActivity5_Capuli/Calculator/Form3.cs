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

        private void Btn_Integer_Click(object sender, EventArgs e)
        {
            int number = 25;
            MessageBox.Show(number.ToString());
        }

        private void Btn_Float_Click(object sender, EventArgs e)
        {
            float number = 25.78F;
            MessageBox.Show(number.ToString());
        }

        private void Btn_Double_Click(object sender, EventArgs e)
        {
            double number = 25.7889;
            MessageBox.Show(number.ToString());
        }

        private void Btn_ComputeSum_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber, secondTextBoxNumber, sum;
            firstTextBoxNumber = int.Parse(TxtBox_1.Text);
            secondTextBoxNumber = int.Parse(TxtBox_2.Text);
            sum = firstTextBoxNumber + secondTextBoxNumber;
            MessageBox.Show("Sum is " + sum.ToString());
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
