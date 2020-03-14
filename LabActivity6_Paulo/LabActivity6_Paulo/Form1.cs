using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity6_Paulo
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

        private void bSITToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void _2ND_YEARToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter._2ND_YEAR(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aDDRESS_BALANGAToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.ADDRESS_BALANGA(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void _2ND_YEAR1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter._2ND_YEAR1(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aDDRESS_BALANGA1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.ADDRESS_BALANGA1(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aDDRESS_BALANGA2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.ADDRESS_BALANGA2(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sECTION_2BToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.SECTION_2B(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lASTNAME_A_AND_CToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.LASTNAME_A_AND_C(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lASTNAME_A_AND_C1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.LASTNAME_A_AND_C1(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fIRSTNAME_CONSONANTToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.FIRSTNAME_CONSONANT(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
