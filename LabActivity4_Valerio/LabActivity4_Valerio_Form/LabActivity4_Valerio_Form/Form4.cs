using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity4_Valerio_Form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txt_ans_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txtbx_snum.Text);
            txtbx_ans.Text = (num1 + num2).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txtbx_snum.Text);
            txtbx_ans.Text = (num1 - num2).ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txtbx_snum.Text);
            txtbx_ans.Text = (num1 * num2).ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txtbx_snum.Text);
            txtbx_ans.Text = (num1 / num2).ToString();
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbx_fnum.Text);
            num2 = Convert.ToInt32(txtbx_snum.Text);
            txtbx_ans.Text = (num1 % num2).ToString();
        }

        private void txt_bck_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.Show();
        }
    }
}
