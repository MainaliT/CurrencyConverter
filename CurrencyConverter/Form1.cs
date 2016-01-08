using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        double result;
        double input;

        public Form1()
        {
            InitializeComponent();
        }

        private void Rbtn1_CheckedChanged(object sender, EventArgs e)
        {
           // label1.Text = "Dollars";
            //label2.Text = "Euros";

        }

        private void Rbtn2_CheckedChanged(object sender, EventArgs e)
        {
           // label1.Text = "Euros";
           // label2.Text = "Dollars";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rbtn1.Checked)
            {
                input = Double.Parse(textBox1.Text);
                result = input * 0.88056;
            }
            else if (Rbtn2.Checked)
            {
                input = Double.Parse(textBox1.Text);
                result = input / 0.88056;
            }

            // this will round up to two digit
            if (Rbtn1.Checked)
            {
                textBox2.Text = "" + System.Math.Round(result, 2) + " Euro";
            } else if (Rbtn2.Checked) {
                textBox2.Text = "$ " + System.Math.Round(result, 2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
