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

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbox_firstnumber.Text);
            num2 = Convert.ToInt32(txtbox_secondnumber.Text);
            txtbox_answer.Text = (num1 + num2).ToString();
        }

        private void btn_difference_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbox_firstnumber.Text);
            num2 = Convert.ToInt32(txtbox_secondnumber.Text);
            txtbox_answer.Text = (num1 - num2).ToString();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbox_firstnumber.Text);
            num2 = Convert.ToInt32(txtbox_secondnumber.Text);
            txtbox_answer.Text = (num1 * num2).ToString();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbox_firstnumber.Text);
            num2 = Convert.ToInt32(txtbox_secondnumber.Text);
            txtbox_answer.Text = (num1 / num2).ToString();
        }

        private void btn_remainder_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtbox_firstnumber.Text);
            num2 = Convert.ToInt32(txtbox_secondnumber.Text);
            txtbox_answer.Text = (num1 % num2).ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
