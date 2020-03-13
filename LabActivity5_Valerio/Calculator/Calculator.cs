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
    public partial class Calculator : Form
    {
        double total1 = 0;
        double total2 = 0;
        bool btnPlusClicked = false;
        bool btnMinusClicked = false;
        bool btnMultClicked = false;
        bool btnDivideClicked = false;

        public Calculator()
        {
            
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //double total1 = 0;
            
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            btnPlusClicked = true;
            btnMinusClicked = false;
            btnMultClicked = false;
            btnDivideClicked = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            
            if (btnPlusClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (btnMinusClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (btnMultClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (btnDivideClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString(); total1 = 0;
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            btnPlusClicked = false;
            btnMinusClicked = true;
            btnMultClicked = false;
            btnDivideClicked = false;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnMultClicked = true;
            btnDivideClicked = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnMultClicked = false;
            btnDivideClicked = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void BtdFrm3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
