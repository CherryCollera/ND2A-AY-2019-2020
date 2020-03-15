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

        private void txt_myprofile_Click(object sender, EventArgs e)
        {

        }

        private void btn_getMyProfile_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Hello"  + " " + txtbx_fname.Text + " " + txtbx_Lname.Text + "!!!" + "\n\nDate Of Birth: December 18, 2000 " + "\nCourse: BSCS" + "\nYear: 2nd" + "\nSection: ND2A");
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
    }
}
