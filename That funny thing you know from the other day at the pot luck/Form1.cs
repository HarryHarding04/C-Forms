using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace That_funny_thing_you_know_from_the_other_day_at_the_pot_luck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_integer_Click(object sender, EventArgs e)
        {
            int myInteger;
            myInteger = 25;
            MessageBox.Show(myInteger.ToString());

        }

        private void Btn_strng_Click(object sender, EventArgs e)
        {
            string Writing = textBox1.Text;
            /*MessageBox.Show(firstName);*/
            lblchange.Text = Writing;
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string years = textBox4.Text;
            lblname.Text = textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;

        }

        private void btnfloat_Click(object sender, EventArgs e)
        {
            float myFloat;
            myFloat = 0.48F;
            MessageBox.Show(myFloat.ToString());
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
        
            int integersum;
            var num1 = Convert.ToInt32(tbnum1.Text);
            var num2 = Convert.ToInt32(tbnum2.Text);

            integersum = num1 + num2;

            lbladd.Text = integersum.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            int integersub;
            var num3 = Convert.ToInt32(tbnum3.Text);
            var num4 = Convert.ToInt32(tbnum4.Text);

            integersub = num3 - num4;

            lblsub.Text = integersub.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            int integerdiv;
            var num5 = Convert.ToInt32(tbnum5.Text);
            var num6 = Convert.ToInt32(tbnum6.Text);

            integerdiv = num5 / num6;

            integerdiv = (int)Convert.ToSingle(integerdiv);

            lbldiv.Text = integerdiv.ToString();
        }
    }
}
