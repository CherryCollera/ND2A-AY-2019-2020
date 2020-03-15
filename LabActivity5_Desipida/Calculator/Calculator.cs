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
        bool BtnAddClicked = false;
        bool SubBtnClicked = false;
        bool MultiplyBtnClicked = false;
        bool DivideBtnClicked = false;


        public Calculator()
        {
            InitializeComponent();
        }
        

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textDisplay.Text);
            textDisplay.Clear();
            BtnAddClicked = true;
            SubBtnClicked = false;
            MultiplyBtnClicked = false;
            DivideBtnClicked = false;

        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textDisplay.Text);
            textDisplay.Clear();
            BtnAddClicked = false;
            SubBtnClicked = true;
            MultiplyBtnClicked = false;
            DivideBtnClicked = false;
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textDisplay.Text);
            textDisplay.Clear();
            BtnAddClicked = false;
            SubBtnClicked = false;
            MultiplyBtnClicked = true;
            DivideBtnClicked = false;
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textDisplay.Text);
            textDisplay.Clear();
            BtnAddClicked = false;
            SubBtnClicked = false;
            MultiplyBtnClicked = false;
            DivideBtnClicked = true;
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnOne.Text;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnTwo.Text;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnThree.Text;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnFour.Text;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnFive.Text;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnSix.Text;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnSeven.Text;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnEight.Text;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnNine.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
          
            if (BtnAddClicked == true)
            {
                total2 = total1 + double.Parse(textDisplay.Text);
            }
            else if(SubBtnClicked == true)
            {
                total2 = total1 - double.Parse(textDisplay.Text);
            }
            else if(MultiplyBtnClicked == true)
            {
                total2 = total1 * double.Parse(textDisplay.Text);
            }
            else if (DivideBtnClicked == true)
            {
                total2 = total1 / double.Parse(textDisplay.Text);
            }

                textDisplay.Text = total2.ToString(); total1 = 0;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnZero.Text;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btnDot.Text;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_GotoForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
