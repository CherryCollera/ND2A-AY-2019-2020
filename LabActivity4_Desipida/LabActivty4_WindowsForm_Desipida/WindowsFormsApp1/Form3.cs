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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Getmyprofile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t Hello " + FName.Text + " " + Lname.Text + "\nDate of Birth \t\t: \t\t October 22,1999 \nCourse \t\t\t: \t\t BS Computer Science \nYear \t\t\t: \t\t 2nd \nSection \t\t\t: \t\t ND2A1");        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
           
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }
    }
}
