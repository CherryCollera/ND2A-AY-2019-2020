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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_msg_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show(hb.getmessage("Happy Birthday!"));
   
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
