using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_getmessage_Click(object sender, EventArgs e)
        {

            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show("Happy Birthday " + Fname.Text + " " + Lname.Text);

        }

        private void back(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
