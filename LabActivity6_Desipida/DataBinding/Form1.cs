using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
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

        //private void bSCSToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.tblStudent_InfoTableAdapter.BSCS(this.studentsDataSet.tblStudent_Info);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

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

        private void bSCS1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.BSCS1(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bSITToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.BSIT(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void balangaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.Balanga(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void _2nd_YearToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter._2nd_Year(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void section_2BToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.tblStudent_InfoTableAdapter.Section_2B(this.studentsDataSet.tblStudent_Info);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void firstName_ConsonantsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.FirstName_Consonants(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lastNameACToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.LastNameAC(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void _2B_SectionToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter._2B_Section(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
