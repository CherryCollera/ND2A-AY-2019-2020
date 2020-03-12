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

        bool mulClicked = false;
        bool subClicked = false;
        bool addClicked = false;
        bool dvdClicked = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void Button7_Click(object sender, EventArgs e)
        {


        }

        private void Btn_mul_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            mulClicked = true;
            subClicked = false;
            addClicked = false;
            dvdClicked = false;

        }

        private void Btn_sub_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            mulClicked = false;
            subClicked = true;
            addClicked = false;
            dvdClicked = false;

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            mulClicked = false;
            subClicked = false;
            addClicked = true;
            dvdClicked = false;


        }

        private void Btn_dvd_Click(object sender, EventArgs e)
        {
            total1 = total1  +  double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            mulClicked = false;
            subClicked = false;
            addClicked = false;
            dvdClicked = true;

        }

        private void Btn_Eq_Click(object sender, EventArgs e)
        {
            if (addClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (subClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (mulClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (dvdClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString(); total1 = 0;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_1.Text;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_2.Text;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_3.Text;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_9.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + Btn_0.Text;
        }

        private void Btn_clr_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();

            total2 = 0;

        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void Btn_f3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Hide();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
