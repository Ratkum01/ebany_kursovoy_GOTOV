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
    
    public partial class Request_3 : Form
    {
        public Request_3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
             FormRequest hr = new FormRequest();
            hr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Discipliny where name like '" + textBox1.Text + "%'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
