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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_mp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t Hello " + box_fn.Text + " " + box_ln.Text + 
                "\nDate of Birth \t\t: \t\t December 07, 1999 " +
                "\nCourse \t\t\t: \t\t BS Computer Science " +
                "\nYear \t\t\t: \t\t 2nd Year" +
                "\nSection \t\t\t: \t\t 2A");
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void btn_calcu_Click(object sender, EventArgs e)
        {

            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }
    }
}
