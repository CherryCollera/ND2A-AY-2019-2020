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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (num1 + num2).ToString();

        }
                

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (num1 - num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (num1 * num2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (num1 / num2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frn = new Form3();
            this.Hide();
            frn.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
