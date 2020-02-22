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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t Hello " + textBox1.Text + " " + textBox2.Text+ "\nDate of Birth\t:\tMay 23, 2000\n"+ "Couse\t\t:\tBS Computer Science\n"+ "Year\t\t:\t2nd Year\n"+ "Section\t\t:\tA\n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ee = new Form2();
            ee.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 r = new Form4();
            r.Show();
            this.Hide();
        }
    }
}
