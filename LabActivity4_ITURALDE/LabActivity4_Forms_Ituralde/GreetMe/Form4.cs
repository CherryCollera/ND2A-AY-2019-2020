using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetMe
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bttn_Sum_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Answer.Text = (num1 + num2).ToString();
        }

        private void bttn_Difference_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Answer.Text = (num1 +- num2).ToString();
        }

        private void bttn_Product_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Answer.Text = (num1 * num2).ToString();
        }

        private void bttn_Quotient_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Answer.Text = (num1 / num2).ToString();
        }

        private void bttn_Rem_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Answer.Text = (num1 % num2).ToString();
        }

        private void bttn_Back_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.Show();
        }
    }
}
