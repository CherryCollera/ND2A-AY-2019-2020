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
        bool BtnSumClicked = false;
        bool BtnDifferenceClicked = false;
        bool BtnProductClicked = false;
        bool BtnQuotientClicked = false;

        public Calculator()
        {
         
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
          BtnSumClicked = true;
           BtnDifferenceClicked = false;
           BtnProductClicked = false;
           BtnQuotientClicked = false;

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
           
            if (BtnSumClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (BtnDifferenceClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (BtnProductClicked == true)
             {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (BtnQuotientClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString();total1 = 0;
        }

        private void BtnDifference_Click(object sender, EventArgs e)
        {
            
            total1= total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            BtnSumClicked = false;
            BtnDifferenceClicked = true;
            BtnProductClicked = false;
            BtnQuotientClicked = false;
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            BtnSumClicked = false;
            BtnDifferenceClicked = false;
            BtnProductClicked = true;
            BtnQuotientClicked = false;
        }

        private void BtnQuotient_Click(object sender, EventArgs e)
        {
            
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            BtnSumClicked = false;
            BtnDifferenceClicked = false;
            BtnProductClicked = false;
            BtnQuotientClicked = true;
        }

        private void BtnBackForm1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void BtnBackForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDecimal.Text;
        }
    }

}
