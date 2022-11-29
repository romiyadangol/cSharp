using System.ComponentModel;
using System.Data.SqlClient;

namespace Romiya_D3_Employee_
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection
            (@"Data source=.\SQLEXPRESS;
            Initial catalog=emp;
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
                string query = "Insert into employee values('Rose','patan','20000')";
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
                string query = "Update employee SET name = 'Hari' where id =1;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");
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
                string query = "Delete from employee where address is 'patan';";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.InnerException);
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("5", "Shyam", "Gorkha", "40000");
            dataGridView1.Rows.Add(id.Text, name.Text, address.Text, salary.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}