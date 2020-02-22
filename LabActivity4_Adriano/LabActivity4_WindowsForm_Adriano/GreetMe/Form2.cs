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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GetMessage_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show("Happy Birthday " + txtbox_fname.Text + " "+ txtbox_lname.Text );
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
