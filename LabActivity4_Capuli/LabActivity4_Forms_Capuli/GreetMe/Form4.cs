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

        private void txtBox_Fnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Ans_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Ans.Text = (num1 + num2).ToString();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Ans.Text = (num1 - num2).ToString();
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Ans.Text = (num1 * num2).ToString();
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Ans.Text = (num1 / num2).ToString();
        }

        private void btn_Modulo_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtBox_Fnum.Text);
            num2 = Convert.ToInt32(txtBox_SNum.Text);
            txtBox_Ans.Text = (num1 % num2).ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }
    }
}
