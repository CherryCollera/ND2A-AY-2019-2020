using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_Miller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.tblStudent_Info' table. You can move, or remove it, as needed.
            this.tblStudent_InfoTableAdapter.Fill(this.studentsDataSet.tblStudent_Info);

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.Refresh(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bSCSToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.BSCS(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.FillBy(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
