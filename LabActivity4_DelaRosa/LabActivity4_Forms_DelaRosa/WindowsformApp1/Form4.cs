using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsformApp1
{
    public partial class Form4 : Form

    {
        double a, b, result;

        public Form4()
        {
            InitializeComponent();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 rr = new Form3();
            rr.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            result = a + b;
            textBox3.Text = result.ToString("n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            result = a - b;
            textBox3.Text = result.ToString("n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            result = a * b;
            textBox3.Text = result.ToString("n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            result = a / b;
            textBox3.Text = result.ToString("n");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            button1.Controls.Clear();
            button2.Controls.Clear();
            button3.Controls.Clear();
            button4.Controls.Clear();

            textBox1.Focus();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
