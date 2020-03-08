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

        private void Msg_Click(object sender, EventArgs e)
        {
          DialogResult=  MessageBox.Show("Hello", "My message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (DialogResult == DialogResult.Yes)
            {
                Calculator f3 = new Calculator();
                f3.Show();
                Hide();
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
