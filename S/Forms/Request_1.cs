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
    public partial class Request_1 : Form
    {

        public Request_1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select p.fio, v.name from Prepodavateli p  left join Nagruzka n on n.code_prepodavatelya=p.code left join Vidy_uchebnoi_nagruzki v on v.code=n.code_vida_nagruzki  where  p.code= '" + textBox1.Text + "'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.FormRequest hr = new Forms.FormRequest();
            hr.Show();
        }

        private void Request_1_Load(object sender, EventArgs e)
        {

        }
    }
}
