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

        private void bttn_GetMyProfile_Click(object sender, EventArgs e)
        {
           MessageBox.Show( "\t\t Hello " + textBox1.Text + " " + textBox2.Text + "!!!" + "\n\nDate of Birth \t\t: \t\t July 3, 1999 \nCourse \t\t\t: \t\t BS Computer Science \nYear \t\t\t: \t\t 2nd \nSection \t\t\t: \t\t 2A");
        }

        private void bttn_Back_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void bttn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
