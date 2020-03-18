using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {

        double total1 = 0;
        double total2 = 0;

        bool btnAdd = false, btnDiff = false, btnDiv = false, btnMulti = false;

        private void Btn_add_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_ShowNumber.Text);
            txt_ShowNumber.Clear();
            btnAdd = true;
            btnDiff = false;
            btnDiv = false;
            btnMulti = false;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += Btn_2.Text;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += Btn_3.Text;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_4.Text;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_5.Text;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_6.Text;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_7.Text;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_8.Text;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_9.Text;
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_0.Text;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            /*btnAdd = true;
            btnDiff = false;
            btnDiv = false;
            btnMulti = false;*/
            if (btnAdd == true)
                total2 = total1 + double.Parse(txt_ShowNumber.Text);
            else if(btnDiff == true)
                total2 = total1 - double.Parse(txt_ShowNumber.Text);
            else if (btnDiv == true)
                total2 = total1 / double.Parse(txt_ShowNumber.Text);
            else if (btnMulti == true)
                total2 = total1 * double.Parse(txt_ShowNumber.Text);
            txt_ShowNumber.Text = total2.ToString();
            total1 = 0;
        }

        private void Btn_quotient_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_ShowNumber.Text);
            txt_ShowNumber.Clear();
            btnAdd = false;
            btnDiff = false;
            btnDiv = true;
            btnMulti = false;
        }

        private void Btn_difference_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_ShowNumber.Text);
            txt_ShowNumber.Clear();
            btnAdd = false;
            btnDiff = true;
            btnDiv = false;
            btnMulti = false;
        }

        private void Btn_product_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_ShowNumber.Text);
            txt_ShowNumber.Clear();
            btnAdd = false;
            btnDiff = false;
            btnDiv = false;
            btnMulti = true;
        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += btn_dot.Text;
        }

        private void Btn_frm3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Hide();
            f3.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.Show();
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            txt_ShowNumber.Text += Btn_1.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
