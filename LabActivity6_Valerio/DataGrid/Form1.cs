﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
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

        private void section_2BToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.Section_2B(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void address_BalangaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.Address_Balanga(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lastName_AandCToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.LastName_AandC(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void firstnames_ConsonantsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.Firstnames_Consonants(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

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
    }
}
