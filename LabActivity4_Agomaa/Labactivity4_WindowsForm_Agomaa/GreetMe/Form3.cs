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

        private void btn_GetMyProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t Hello " + txtbox_Fname.Text + " " + txtbox_Lname.Text +"\n" +  "Date of Birth\t\t: June 01, 2000\nCourse\t\t:\t\tBS Computer Science\nYear:\t\t:\t\tII\nSection\t\t:\t\tA ");
           
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
