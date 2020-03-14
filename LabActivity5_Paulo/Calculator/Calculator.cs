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
        double total1 = 0;
        double total2 = 0;

        bool btnPlusClicked = false;
        bool btnMinusClicked = false;
        bool btnTimesClicked = false;
        bool btnDivideClicked = false;

        public Form1()
            {
                InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            btnPlusClicked = true;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnTimesClicked = false;    
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
          
            if (btnPlusClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (btnMinusClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (btnTimesClicked == true)
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
             btnMinusClicked =true;
             btnTimesClicked = false;
             btnDivideClicked = false;
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            btnPlusClicked = false;
            btnMinusClicked = false;
            btnTimesClicked = true;
            btnDivideClicked = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            btnPlusClicked = false;
            btnMinusClicked = false;
            btnTimesClicked = false;
            btnDivideClicked = true;
        }

        private void BtnBckFrm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
