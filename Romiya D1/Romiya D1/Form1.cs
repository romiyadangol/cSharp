using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romiya_D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string data = username.Text;
            // if(data == "romiya")
            // {
            // MessageBox.Show("Success");
            // }
            // else
            // {
            // MessageBox.Show("Failed");
            // }
            // for(int i=0;i<3;i++)
            // {
            // MessageBox.Show(data);
            // MessageBox.Show("Display time : " + i);
            /*try
            {
                int age_input = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Age: " + age_input);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid number:"+ex);
            }*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "Test";
        }
    }
}
