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
    public partial class Form2 : Form
    {
        System.Data.SqlClient.SqlConnection conn = new SqlConnection
               (@"Data source=.\SQLEXPRESS;
            Initial catalog=emp_details;
            user id=sa;password=kist@123;");
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "Select * from employee";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt); 
           // dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Insert into employee" + "(name,address,salary)" + "values('"+textBox2.Text + "','"+textBox3.Text +"','"+textBox4.Text + "')";
            SqlCommand cmd=conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
