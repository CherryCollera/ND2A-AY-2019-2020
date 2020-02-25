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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t Hello " + textBox1.Text + " " + textBox2.Text + " !!!" + "\n\nDate of Birth \t\t: February 4, 2000" + "\n\n Course\t\t: BSCS" + "\n\nYear\t\t: 2nd" + "\n\nSection\t\t: A");
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frn = new Form2();
            this.Hide();
            frn.Show();
        }
    }
}

