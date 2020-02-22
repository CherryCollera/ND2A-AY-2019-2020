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
        double a, b;

        public Form4()
        {
            InitializeComponent();
        }

        private void Txtbox_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Lname_Click(object sender, EventArgs e)
        {

        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Txtbox_Fnum.Text);
            b = Convert.ToDouble(Txtbox_Snum.Text);
            TxtAnswer.Text = (a + b).ToString();
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Txtbox_Fnum.Text);
            b = Convert.ToDouble(Txtbox_Snum.Text);
            TxtAnswer.Text = (a - b).ToString();
        }

        private void Btn_times_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Txtbox_Fnum.Text);
            b = Convert.ToDouble(Txtbox_Snum.Text);
            TxtAnswer.Text = (a * b).ToString();
        }

        private void Btn_divide_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Txtbox_Fnum.Text);
            b = Convert.ToDouble(Txtbox_Snum.Text);
            TxtAnswer.Text = (a / b).ToString();
        }

        private void Btn_remainder_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Txtbox_Fnum.Text);
            b = Convert.ToDouble(Txtbox_Snum.Text);
            TxtAnswer.Text = (a % b).ToString();
        }

        private void Btn_bck_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
