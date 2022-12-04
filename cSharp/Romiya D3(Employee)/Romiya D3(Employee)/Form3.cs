using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romiya_D3_Employee_
{
    public partial class Form3 : Form
    {
        System.Data.SqlClient.SqlConnection conn = new SqlConnection
               (@"Data source=.\SQLEXPRESS;
            Initial catalog=emp_details;
            Integrated Security=True;");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow data = dataGridView1.CurrentRow;
            string emp_name = data.Cells["name"].Value.ToString();
            string emp_address = data.Cells["address"].Value.ToString();
            string emp_salary = data.Cells["salary"].Value.ToString();
            MessageBox.Show("Selected Name: " + emp_name);
            MessageBox.Show("Selected Address: " + emp_address);
            MessageBox.Show("Selected Salary: " + emp_salary);

            textBox1.Text = emp_name;
            textBox2.Text = emp_address;    
            textBox3.Text = emp_salary;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string Query = "select * from employee";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            conn.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string query = "Select * from employee";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
