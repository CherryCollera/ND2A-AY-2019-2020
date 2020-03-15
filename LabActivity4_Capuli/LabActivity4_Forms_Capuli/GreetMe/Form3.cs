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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_MyProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t Hello " + txtBox_FN.Text + " " + txtBox_LN.Text + "!!!" +"\n\nDate of Birth \t\t: \t\t October 11,1999 \nCourse \t\t\t: \t\t BS Computer Science \nYear \t\t\t: \t\t 2nd \nSection \t\t\t: \t\t 2A");
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
    }
}
