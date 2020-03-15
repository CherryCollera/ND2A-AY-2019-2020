using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp1_Salas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textAnswer.Text = (num1 + num2).ToString();

        }

        private void Sub_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textAnswer.Text = (num1 - num2).ToString();
        }

        private void Prod_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textAnswer.Text = (num1 * num2).ToString();
        }

        private void quot_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textAnswer.Text = (num1 / num2).ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.Show();

        }

        private void modulo_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textAnswer.Text = (num1 % num2).ToString();
        }
    }
}
