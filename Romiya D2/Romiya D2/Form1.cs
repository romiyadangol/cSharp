﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "7";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text =data + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text =data + "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text =data +"0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = "Ans";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text =data + "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "%";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text =data + "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text =data + "-";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
