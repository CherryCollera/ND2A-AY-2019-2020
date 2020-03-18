using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_int_Click(object sender, EventArgs e)
        {
            int number = 25;
            MessageBox.Show(number.ToString());
        }

        private void Btn_float_Click(object sender, EventArgs e)
        {
            float number = 25.78F;
            MessageBox.Show(number.ToString());
        }

        private void Btn_Double_Click(object sender, EventArgs e)
        {
            double number = 25.7889;
            MessageBox.Show(number.ToString());
        }

        private void Btn_compute_Click(object sender, EventArgs e)
        {
            int firstNum, secondNum, sum;
            firstNum = int.Parse(Txt_1st.Text);
            secondNum = int.Parse(Txt_2nd.Text);
            sum = firstNum + secondNum;
            MessageBox.Show("Sum is " + sum.ToString());

        }

        private void Btn_Ext_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
