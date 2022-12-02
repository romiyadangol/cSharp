using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romiya_D3_Employee_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow data = dataGridView1.CurrentRow;
            string emp_name = data.Cells["empname"].Value.ToString();
            string emp_address = data.Cells["empaddress"].Value.ToString();
            string emp_salary = data.Cells["empsalary"].Value.ToString();
            MessageBox.Show("Selected Name: " + emp_name);
            MessageBox.Show("Selected Address: " + emp_address);
            MessageBox.Show("Selected Salary: " + emp_salary);

            textBox1.Text = emp_name;
            textBox2.Text = emp_address;    
            textBox3.Text = emp_salary;
        }
    }
}
