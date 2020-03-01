using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm1_Canlong
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(box_no1.Text);
            b = Convert.ToInt32(box_no2.Text);
            box_answer.Text = (a + b).ToString();
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(box_no1.Text);
            b = Convert.ToInt32(box_no2.Text);
            box_answer.Text = (a * b).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(box_no1.Text);
            b = Convert.ToInt32(box_no2.Text);
            box_answer.Text = (a - b).ToString();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(box_no1.Text);
            b = Convert.ToInt32(box_no2.Text);
            box_answer.Text = (a / b).ToString();
        }

        private void btn_remainder_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(box_no1.Text);
            b = Convert.ToInt32(box_no2.Text);
            box_answer.Text = (a % b).ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
