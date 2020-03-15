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
        bool AddButtonClicked = false;
        bool SubtractButtonClicked = false;
        bool DivideButtonClicked = false;
        bool MultiplyButtonClicked = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnThree.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (AddButtonClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }

            else if (SubtractButtonClicked == true) 
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }

            else if (MultiplyButtonClicked == true) 
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }

            else if (DivideButtonClicked == true) 
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString(); total1 = 0;                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnOne.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            AddButtonClicked = true;
            SubtractButtonClicked = false;
            MultiplyButtonClicked = false;
            DivideButtonClicked = false;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnTwo.Text;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnFour.Text;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnFive.Text;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnSix.Text;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnSeven.Text;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnEight.Text;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnNine.Text;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnZero.Text;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnDot.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void BtnForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            AddButtonClicked = false;
            SubtractButtonClicked = false;
            MultiplyButtonClicked = true;
            DivideButtonClicked = false;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            AddButtonClicked = false;
            SubtractButtonClicked = false;
            MultiplyButtonClicked = false;
            DivideButtonClicked = true;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            AddButtonClicked = false;
            SubtractButtonClicked = true;
            MultiplyButtonClicked = false;
            DivideButtonClicked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnEight.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnFive.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnOne.Text;
        }

        private void BtnForm3_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }
    }
}
