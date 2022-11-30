using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Romiya_D3_Employee_
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection
            (@"Data source=.\SQLEXPRESS;
            Initial catalog=emp_details;
            user id=sa;password=kist@123;");

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Insert into employee values('" + txtUserName.Text
                + "','" + txtUserAddr.Text + "','" + txtUserSalary.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.InnerException);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "update Student set name='" + txtUserName.Text + "', address='" + txtUserAddr.Text + "' ,salary ='" + txtUserSalary.Text + "', where id = '" + txtUserID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.InnerException);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "delete from employee where id = '" + txtUserID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.InnerException);
            }
        }

        private void Display_Click(object sender, EventArgs e)
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

            /*dataGridView1.Rows.Add("5", "Shyam", "Gorkha", "40000");
            dataGridView1.Rows.Add(id.Text, txtUserName.Text, txtUserAddr.Text, txtUserSalary.Text);*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUserAddr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}