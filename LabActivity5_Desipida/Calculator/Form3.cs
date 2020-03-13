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
            int number = 22;
            MessageBox.Show(number.ToString());
        }

        private void Btn_Float_Click(object sender, EventArgs e)
        {
            float number = 1022.654F;
            MessageBox.Show(number.ToString());
        }

        private void Btn_Double_Click(object sender, EventArgs e)
        {
            double number = 22.99999999;
            MessageBox.Show(number.ToString());
        }

        private void Btn_ComputeSum_Click(object sender, EventArgs e)
        {
            int FirstNumber, SecondNumber, Sum;
            FirstNumber = int.Parse(Txt_Box1.Text);
            SecondNumber = int.Parse(Txt_Box2.Text);
            Sum = FirstNumber + SecondNumber;
            MessageBox.Show("Sum is " + Sum.ToString());

        }

        private void Btn_Ext_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Lbl_Secondnum_Click(object sender, EventArgs e)
        {

        }
    }
}
