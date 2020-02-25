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

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txt_Secnum.Text);
            txtbx_Ans.Text = (num1 + num2).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Diff_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txt_Secnum.Text);
            txtbx_Ans.Text = (num1 - num2).ToString();
        }

        private void btn_Prod_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txt_Secnum.Text);
            txtbx_Ans.Text = (num1 * num2).ToString();
        }

        private void btn_Quotient_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txt_Secnum.Text);
            txtbx_Ans.Text = (num1 / num2).ToString();
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txt_Secnum.Text);
            txtbx_Ans.Text = (num1 % num2).ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.Show();
        }
    }
}
