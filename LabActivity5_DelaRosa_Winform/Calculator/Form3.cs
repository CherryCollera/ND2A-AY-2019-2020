using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn3_dou_Click(object sender, EventArgs e)
        {
            double Number = 25.7889;
            MessageBox.Show(Number.ToString());
        }

        private void Btn1_int_Click(object sender, EventArgs e)
        {
            int Number = 25;
            MessageBox.Show(Number.ToString());
        }

        private void Btn2_fl_Click(object sender, EventArgs e)
        {
            float Number = 25.78f;
            MessageBox.Show(Number.ToString());
        }

        private void Btn4_coms_Click(object sender, EventArgs e)
        {
            int fnumber, secondnum, sum;
            fnumber = int.Parse(textBox1.Text);
            secondnum = int.Parse(textBox2.Text);
            sum = fnumber + secondnum;
            MessageBox.Show("Sum is " + sum.ToString());
        }

        private void Btnex_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
