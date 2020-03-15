using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(Fnum.Text);
            b = Convert.ToInt32(Snum.Text);
            Ans.Text = (a + b).ToString();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(Fnum.Text);
            b = Convert.ToInt32(Snum.Text);
            Ans.Text = (a - b).ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(Fnum.Text);
            b = Convert.ToInt32(Snum.Text);
            Ans.Text = (a * b).ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Double a, b;
            a = Convert.ToDouble(Fnum.Text);
            b = Convert.ToDouble(Snum.Text);
            Ans.Text = (a / b).ToString();
        }

        private void Remainder_Click(object sender, EventArgs e)
        {
            Double a, b;
            a = Convert.ToDouble(Fnum.Text);
            b = Convert.ToDouble(Snum.Text);
            Ans.Text = (a % b).ToString();
        }
    }
}
