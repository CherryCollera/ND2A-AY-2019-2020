﻿using System;
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

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Hello", "My Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Calculator fr = new Calculator();
                fr.Show();
                this.Hide();
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
