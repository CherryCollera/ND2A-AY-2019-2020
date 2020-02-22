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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GetMessage_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show(hb.GetMessage("Lovely"));
            this.Close();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {

        }
    }
}
