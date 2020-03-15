using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity4_Valerio_Form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_getMyProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("\tHello " + txtbx_fname.Text + " " + txtbx_lname.Text + "!!!" + "\n\nDate Of Birth: August 2, 2000" + "\nCourse: BSCS" + "\nYear: 2nd Year" + "\nSection: ND2A1");
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
