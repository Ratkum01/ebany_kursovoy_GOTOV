using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*   1q @W3e$R    */
namespace S
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password;

            Username = txtName.Text;
            Password = txtPass.Text;

            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GCEHHTV\SQLEXPRESS;Initial Catalog=master;User ID=" + txtName.Text + ";Password=" + txtPass.Text + "");


                this.Hide();
                MainForm1 h = new MainForm1();
                h.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Username, Password;

            Username = txtName.Text;
            Password = txtPass.Text;

            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GCEHHTV\SQLEXPRESS;Initial Catalog=master;User ID=" + txtName.Text + ";Password=" + txtPass.Text + "");


                this.Hide();
                MainForm1 h = new MainForm1();
                h.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxPass_CheckedChanged_1(object sender, EventArgs e)
        {
                if (checkBoxPass.Checked == false)
                    txtPass.UseSystemPasswordChar = false;
                else
                    txtPass.UseSystemPasswordChar = true;

        }

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblClear_Click_1(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
           Form_Registration hr = new Form_Registration();
            hr.Show();
        }
    }
}
