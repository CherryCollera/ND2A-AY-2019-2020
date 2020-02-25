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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttn_GetMessage_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show("Happy Birthday " + textBox1.Text + " " + textBox2.Text + "!!!");
        }

        private void bttn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bttn_Back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
