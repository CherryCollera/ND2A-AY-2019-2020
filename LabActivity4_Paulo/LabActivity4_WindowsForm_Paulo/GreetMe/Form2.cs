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

        private void Txtbox_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GetMessage_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show("Happy Birthday " + Txtbox_Fname.Text +""+ Txtbox_Lname.Text);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
