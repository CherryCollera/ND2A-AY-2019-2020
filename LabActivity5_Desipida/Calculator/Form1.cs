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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Getmessage_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("Hello", "My Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) 
            {
                Calculator frm = new Calculator();
                frm.Show();
                this.Hide();

            }
            else if (DialogResult == DialogResult.No)
            {

            }

        }

    }
}
