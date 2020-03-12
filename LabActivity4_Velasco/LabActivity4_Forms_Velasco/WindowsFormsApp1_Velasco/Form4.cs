using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Velasco
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtBox_fnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Ans_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btn_quo_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(txtBox_fnum.Text);
            b = double.Parse(txtBox_Snum.Text);
            txtBox_Ans.Text = (a / b).ToString();
        }

        private void btn_diff_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(txtBox_fnum.Text);
            b = double.Parse(txtBox_Snum.Text);
            txtBox_Ans.Text = (a - b).ToString();
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(txtBox_fnum.Text);
            b = double.Parse(txtBox_Snum.Text);
            txtBox_Ans.Text = (a * b).ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(txtBox_fnum.Text);
            b = double.Parse(txtBox_Snum.Text);
            txtBox_Ans.Text = (a + b).ToString();
        }

        private void txtBox_Snum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
