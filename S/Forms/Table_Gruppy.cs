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

namespace S.Forms
{

    public partial class Table_Gruppy : Form
    {
        string connectString = Connect.str_connect;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        //SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
        public Table_Gruppy()
        {
            InitializeComponent();
            LoginForm1 view = new LoginForm1();
            display();
        }
        public void display()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    dt = new DataTable();
                    con.Open();
                    adpt = new SqlDataAdapter("select * from Gruppy", con);
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateData()
        {
            //con.Open();
            //DataTable dt = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from Gruppy", con);
            //adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            //{
            //    SqlCommand cmd = new SqlCommand("INSERT INTO Gruppy (   code,name,chislennost,code_kafedry) VALUES(@code,@name,@chislennost,code_kafedry)", con);
            //    con.Open();
            //    cmd.Parameters.AddWithValue("@code", int.Parse(textBox1.Text));
            //    cmd.Parameters.AddWithValue("@name", textBox2.Text);
            //    cmd.Parameters.AddWithValue("@chislennost", int.Parse(textBox3.Text));
            //    cmd.Parameters.AddWithValue("@code_kafedry", int.Parse(textBox4.Text));

            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Работа вставлены");
            //    PopulateData();
            //}
            //else
            //{
            //    MessageBox.Show("Пожалуйста, введите данные!");
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            //{
            //    SqlCommand cmd = new SqlCommand("update Gruppy  set code=@code, name=@name,chislennost=@chislennost code_kafedry=@code_kafedry  WHERE code=@code", con);
            //    con.Open();
            //    cmd.Parameters.AddWithValue("@code", int.Parse(textBox1.Text));
            //    cmd.Parameters.AddWithValue("@name", textBox2.Text);
            //    cmd.Parameters.AddWithValue("@chislennost", textBox3.Text);
            //    cmd.Parameters.AddWithValue("@code_kafedry", textBox3.Text);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Работа изменена");
            //    PopulateData();
            //}
            //else
            //{
            //    MessageBox.Show("Пожалуйста, введите  данные!");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "")
            //{
            //    SqlCommand cmd = new SqlCommand("delete Gruppy Where code=@code", con);
            //    con.Open();
            //    cmd.Parameters.AddWithValue("@code", int.Parse(textBox1.Text));
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Работа удалена");
            //    PopulateData();

            //}
            //else
            //{
            //    MessageBox.Show("Пожалуйста, введите данные!");
            //}
        }
    }
}
