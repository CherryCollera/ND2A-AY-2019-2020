using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double total1 = 0;
        double total2 = 0;

        bool BtnPlusClicked = false;
        bool BtnMinusClicked = false;
        bool BtnDivideClicked = false;
        bool BtnMultiplyClicked = false;

        public Calculator()
        {
           
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOne_Click(object sender, EventArgs e)
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

        private void TxtZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

             BtnMinusClicked =false;
             BtnPlusClicked = true;
             BtnDivideClicked = false;
             BtnMultiplyClicked = false;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            
            if (BtnPlusClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (BtnMinusClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (BtnMultiplyClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (BtnDivideClicked == true)
            {
                total2 = total1/ double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString();total1=0;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            BtnMinusClicked = true;
            BtnPlusClicked = false;
            BtnDivideClicked = false;
            BtnMultiplyClicked = false;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            BtnMinusClicked = false;
            BtnPlusClicked = false;
            BtnDivideClicked = false;
            BtnMultiplyClicked = true;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            BtnMinusClicked = false;
            BtnPlusClicked = false;
            BtnDivideClicked = true;
            BtnMultiplyClicked = false;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {

        }

        private void BtnBackToForm1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void BtnBacktoForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
