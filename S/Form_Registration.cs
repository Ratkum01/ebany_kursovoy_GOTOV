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
    public partial class Form_Registration : Form
    {
        public Form_Registration()
        {
            InitializeComponent();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Integrated Security=SSPI;Initial Catalog=uchebnaya_nagruzka");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("ALTER SERVER ROLE  ADD MEMBER [" + txtName.Text + "] ", con);
            ////[" + comboBox1.Text + "]
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Integrated Security=SSPI;Initial Catalog=master");
            con.Open();
            SqlCommand cmd = new SqlCommand("CREATE LOGIN [" + txtName.Text + "] WITH PASSWORD='" + txtPass.Text + "', DEFAULT_DATABASE=[uchebnaya_nagruzka], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=ON, CHECK_POLICY=ON  ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm1 hr = new LoginForm1();
            hr.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Integrated Security=SSPI;Initial Catalog=master");
            con.Open();
            SqlCommand cmd = new SqlCommand("ALTER SERVER ROLE   [" + txtName.Text + "] ADD MEMBER [" + comboBox1.Text + "]", con);
            //[" + comboBox1.Text + "]
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form_Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
