using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALKULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        // Clear button (C)
        private void button20_Click(object sender, EventArgs e)
        {
            txtShow.Clear();
        }

        // Open parenthesis (
        private void button18_Click(object sender, EventArgs e)
        {
            txtShow.Text += "(";
        }

        // Close parenthesis )
        private void button19_Click(object sender, EventArgs e)
        {
            txtShow.Text += ")";
        }

        // Divide button (/)
        private void button4_Click(object sender, EventArgs e)
        {
            txtShow.Text += "/";
        }

        // Button for number 9
        private void button1_Click(object sender, EventArgs e)
        {
            txtShow.Text += "9";
        }

        // Button for number 8
        private void button2_Click(object sender, EventArgs e)
        {
            txtShow.Text += "8";
        }

        // Button for number 7
        private void button3_Click(object sender, EventArgs e)
        {
            txtShow.Text += "7";
        }

        // Subtract button (-)
        private void button5_Click(object sender, EventArgs e)
        {
            txtShow.Text += "-";
        }

        // Button for number 6
        private void button8_Click(object sender, EventArgs e)
        {
            txtShow.Text += "6";
        }

        // Button for number 5
        private void button7_Click(object sender, EventArgs e)
        {
            txtShow.Text += "5";
        }

        // Button for number 4
        private void button6_Click(object sender, EventArgs e)
        {
            txtShow.Text += "4";
        }

        // Add button (+)
        private void button9_Click(object sender, EventArgs e)
        {
            txtShow.Text += "+";
        }

        // Button for number 3
        private void button12_Click(object sender, EventArgs e)
        {
            txtShow.Text += "3";
        }

        // Button for number 2
        private void button11_Click(object sender, EventArgs e)
        {
            txtShow.Text += "2";
        }

        // Button for number 1
        private void button10_Click(object sender, EventArgs e)
        {
            txtShow.Text += "1";
        }

        // Multiply button (*)
        private void button16_Click(object sender, EventArgs e)
        {
            txtShow.Text += "*";
        }

        // Decimal point button (.)
        private void button13_Click(object sender, EventArgs e)
        {
            txtShow.Text += ".";
        }

        // Button for number 0
        private void button17_Click(object sender, EventArgs e)
        {
            txtShow.Text += "0";
        }

        // Percentage button (%)
        private void button15_Click(object sender, EventArgs e)
        {
            txtShow.Text += "%";
        }

        // Equal button (=), evaluates the expression
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(txtShow.Text, null);
                txtShow.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Expression: " + ex.Message);
            }
        }
    }
}
