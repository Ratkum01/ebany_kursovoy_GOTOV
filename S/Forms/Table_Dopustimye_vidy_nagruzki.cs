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
    public partial class Table_Dopustimye_vidy_nagruzki : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
        public Table_Dopustimye_vidy_nagruzki()
        {
            InitializeComponent();
        }
        private void PopulateData()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Dopustimye_vidy_nagruzki", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text !=  "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Dopustimye_vidy_nagruzki (code_dolzhnosti,code_vida_nagruzki) VALUES(@code_dolzhnosti,@code_vida_nagruzki)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@code_dolzhnosti", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@code_vida_nagruzki", int.Parse(textBox2.Text));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Работа вставлены");
                PopulateData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите данные!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopulateData();
        }
    }
}
