using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm1_Canlong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void box_fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_msg_Click(object sender, EventArgs e)
        {


            HappyBirthday hb = new HappyBirthday();

            MessageBox.Show("Happy Birthday " + box_fn.Text + " " + box_ln.Text);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
