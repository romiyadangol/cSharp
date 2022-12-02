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
            int sn = 1;
           for(int i=0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["column1"].ToString();
                string name = dt.Rows[i]["column2"].ToString();
                string address = dt.Rows[i]["column3"].ToString();
                string salary = dt.Rows[i]["column4"].ToString();
                dataGridView1.Rows.Add(sn++, id, name, address, salary);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*conn.Open();
            string query = "Insert into employee" + "(name,address,salary)" + "values('"+textBox2.Text + "','"+textBox3.Text +"','"+textBox4.Text + "')";
            SqlCommand cmd=conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();*/

            //concatenate 
            conn.Open();
            string query = "Insert into employee" + 
                            "(name,address,salary)" + 
                            "values(@name,@address,@salary)";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name",textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.Parameters.AddWithValue("@salary", textBox4.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            /*
            string query = "Update employee set name" +
                            "(name,address,salary)"+
                            "values(@name,@address,@salary)";

            */
            //string query = update employee set name = 'sandip', address = 'ktm', salary = '9000000' where id = '11'
            //string query = "update employee set" + "(name, address, salary)" + "values(@name,@address,@salary)";
            string query = "update employee set name=@name, address=@address ,salary =@salary where id = @id ";
            SqlCommand cmd = conn.CreateCommand(); 
            cmd.CommandText= query;
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.Parameters.AddWithValue("@salary", textBox4.Text);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
           conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection
             (@"Data source=.\SQLEXPRESS;
            Initial catalog=emp_details;
            user id=sa;password=kist@123;");

            conn.Open();

            string Query = "select * from employee";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

            conn.Close();
        }
    }
}
