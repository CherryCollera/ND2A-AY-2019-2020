using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Canlong
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_Int_Click(object sender, EventArgs e)
        {
            int number = 77;
            MessageBox.Show(number.ToString());
        }

        private void Btn_Float_Click(object sender, EventArgs e)
        {
            float number = 77.77F;
            MessageBox.Show(number.ToString());
        }

        private void Btn_Double_Click(object sender, EventArgs e)
        {
            double number = 77.12345;
            MessageBox.Show(number.ToString());
        }

        private void Btn_CSum_Click(object sender, EventArgs e)
        {
            int firstnum, secondnum, sum;

            firstnum = int.Parse(Txt_First.Text);
            secondnum = int.Parse(Txt_Second.Text);
            sum = firstnum + secondnum;
            MessageBox.Show("Sum is " + sum.ToString());
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
