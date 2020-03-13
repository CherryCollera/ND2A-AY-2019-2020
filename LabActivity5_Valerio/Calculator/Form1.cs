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

        private void btnMsg_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("hello", "My message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Calculator c1 = new Calculator();
                c1.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }
    }
}
