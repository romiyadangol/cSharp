//calculator
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

namespace Romiya_D2
{
    public partial class Form1 : Form
    {
        string operate="";
        decimal calculation = 0;

        SqlConnection conn = new SqlConnection
            (@"Data Source=.\SQLEXPRESS;
            Initial Catalog=bit3rdsem;
            user id= sa;password=kist@123;");
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

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm object_name = new EmployeeForm();
            object_name.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Insert into romiya values ('sony','Manamaiju','9745332324','kist')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                //SqlCommand cmd = conn.CreateCommand();
                // cmd.CommandText = query;
                // cmd.ExecuteNonQuery();


                MessageBox.Show("Saved Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }

        }
        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "update romiya SET name = 'ram' where id = 1;";

               // SqlCommand cmd = new SqlCommand(query, conn);
               // cmd.ExecuteNonQuery();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: "+ex.InnerException);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Delete from romiya where address='bhaktapur';";
               // SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.ExecuteNonQuery();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.InnerException);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //direct adding-----
             dataGridView1.Rows.Add ("1","ROMIYA","KTM","987654321");
            dataGridView1.Rows.Add(id.Text, name.Text, address.Text, contact.Text);
            /*try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from romiya", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }
    }
}
