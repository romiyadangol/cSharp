//calculator
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romiya_D2
{
    public partial class Form1 : Form
    {
        string operate="";
        decimal calculation = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "1";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "2";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "3";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "3";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "4";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "5";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "5";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "6";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "6";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "7";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "7";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "8";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "8";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "9";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "9";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
            {
                textBox1.Text = "0";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = "Ans";
        }
        private void GetResultValue()
        {
            if (textBox1.Text != "" && textBox1.Text != " + " && textBox1.Text != "-" && textBox1.Text != "*" && textBox1.Text != "/" && textBox1.Text != "%")
            {
                calculation = Convert.ToDecimal(textBox1.Text);
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "+";
            textBox1.Text = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "%";
            textBox1.Text = "%";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "*";
            textBox1.Text = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "-";
            textBox1.Text = "-";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "/";
            textBox1.Text = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculation;
            decimal secondNum = Convert.ToDecimal(textBox1.Text);
            decimal ans;
            switch(operate)
            {
                case "+":
                    calculation = (firstNum + secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "-":
                    calculation = (firstNum - secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "%":
                    calculation = (firstNum % secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "/":
                    calculation = (firstNum / secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "*":
                    calculation = (firstNum * secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
