using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_330_0000_97_84
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double answer = 0;
        bool plus = false;
        bool minus = false;
        bool multiply = false;
        bool divide = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(outputBox.Text);

            if (plus == true)
            {
                answer = num1 +num2;
                outputBox.Text = Convert.ToString(answer);
            }
            else if (minus == true)
            {
                answer = num1 - num2;
                outputBox.Text = Convert.ToString(answer);
            }
            else if (divide == true)
            {
                answer = num1 / num2;
                outputBox.Text = Convert.ToString(answer);
            }
            else if (multiply == true)
            {
                answer = num1 * num2;
                outputBox.Text = Convert.ToString(answer);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 6;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Text = outputBox.Text + 0;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            outputBox.Text = outputBox.Text + ".";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(outputBox.Text);

            plus = false;
            minus = false;
            multiply = false;
            divide = true;

            outputBox.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(outputBox.Text);

            plus = false;
            minus = false;
            multiply = true;
            divide = false;

            outputBox.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(outputBox.Text);

            plus = false;
            minus = true;
            multiply = false;
            divide = false;

            outputBox.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(outputBox.Text);

            plus = true;
            minus = false;
            multiply = false;
            divide = false;

            outputBox.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
        }
    }
}
