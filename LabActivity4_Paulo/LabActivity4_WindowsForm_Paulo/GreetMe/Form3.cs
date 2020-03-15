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

        private void Btn_Profile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tHello " + Txtbox_Fname.Text + " " + Txtbox_Lname.Text + "\nDate of Birth\t:\t\tJuly 05, 1999\nCourse\t\t:\t\tBS Computer Science\nYear\t\t:\t\tII\nSection\t\t:\t\tA" );
            

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_bck_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
