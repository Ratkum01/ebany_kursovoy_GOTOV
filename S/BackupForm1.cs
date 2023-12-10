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

namespace S
{

    public partial class BackupForm1 : Form
    {
        public BackupForm1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"RESTORE DATABASE " + comboBox1.Text + " FROM DISK = '" + textBox1.Text + "'; ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DROP DATABASE " + comboBox1.Text + " ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"BACKUP DATABASE " + comboBox1.Text + " TO DISK = '" + textBox1.Text + "'; ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM master.dbo.sysdatabases ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
