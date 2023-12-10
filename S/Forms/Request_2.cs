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
    public partial class Request_2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
        public Request_2()
        {
            InitializeComponent();
        }

        private void Request_2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.FormRequest hr = new Forms.FormRequest();
            hr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(n.kol_chasov)  as obshee_kolichestvo  from Prepodavateli p  left join Nagruzka n on n.code_prepodavatelya=p.code where  n.code_prepodavatelya=  '" + textBox1.Text + "'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
