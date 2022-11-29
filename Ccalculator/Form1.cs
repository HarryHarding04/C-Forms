using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ccalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn0.Text;
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            txtdisplay.Clear();
        }
       double total1 = 0;
       double total2 = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            total2 = total1 + double.Parse(txtdisplay.Text);
            txtdisplay.Text = total2.ToString();
            total1 = 0;
        }
    }
}
