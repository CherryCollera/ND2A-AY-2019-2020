using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Canlong
{
    public partial class Calculator : Form
    {

        double total1 = 0;
        double total2 = 0;

        bool btnplusClicked = false;
        bool btnminusClicked = false;
        bool btndivideClicked = false;
        bool btntimesClicked = false;


        public Calculator()
        {

            InitializeComponent();      
        }

       

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void Btnzero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnzero.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            btnplusClicked = true;
            btnminusClicked = false;
            btntimesClicked = false;
            btndivideClicked = false;
        }
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            
            btnplusClicked = false;
            btnminusClicked = true;
            btntimesClicked = false;
            btndivideClicked = false;
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            btntimesClicked = true;
            btnplusClicked = false;
            btnminusClicked = false;         
            btndivideClicked = false;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();


            btndivideClicked = true;
            btnplusClicked = false;
            btnminusClicked = false;
            btntimesClicked = false;
           
        }



        private void btnequal_Click(object sender, EventArgs e)
        {
            //bool btnplus = true;
            //bool btnminus = false;
            //bool btntimes = false;
            //bool btndivide = false;

            if (btnplusClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (btnminusClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (btntimesClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (btndivideClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btndot.Text;
        }

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void Btn_Form1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
