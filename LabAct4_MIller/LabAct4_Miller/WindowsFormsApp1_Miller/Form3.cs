using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Miller
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_message_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tHello " + txtBox_fname.Text + " " + txtBox_Lname.Text+
                "\nDate of Birth\t:\tJune 09,1999\n"+
                "Course\t\t:\tBS Computer Science\n"+
                "Year\t\t:\t2\n"+
                "Section\t\t:\tA");
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
