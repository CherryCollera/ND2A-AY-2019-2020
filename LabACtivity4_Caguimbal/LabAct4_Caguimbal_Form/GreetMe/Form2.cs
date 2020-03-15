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

        private void txt_lname_Click(object sender, EventArgs e)
        {

        }

        private void btn_getMessage_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show("Happy Birthday" + " " + txtbx_fname.Text +" " + txtbx_lname.Text);

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
