using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
           DialogResult= MessageBox.Show("hello!", "My message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes) 
            {
                Form1 c = new Form1();
                c.Show();
                this.Hide();
            }

            else if (DialogResult == DialogResult.No) ;
            {

            }
           
        }
    }
}
