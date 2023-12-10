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
    public partial class Table_Dolzhnosti : Form
    {
        string connectString = Connect.str_connect;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public Table_Dolzhnosti()
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
                    adpt = new SqlDataAdapter("select * from Dolzhnosti", con);
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
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Dolzhnosti", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Table_Dolzhnosti_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill in the Blanks ");

            }
            else
            {

                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                            if (MessageBox.Show("Точно хотите добавить данные?", "Подтверждения действия!!!", MessageBoxButtons.YesNo)== DialogResult.Yes)
                            { 
                                
                                con.Open();

                                cmd = new SqlCommand("insert into Dolzhnosti (Code, name) values ('" + textBox1.Text + "', '" + textBox2.Text + "')", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Ваши данные добавлены ");
                                //clear();
                                display();
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //public void clear()
        //{
        //    textBox1.Text = "";
        //    textBox2.Text = "";
        //}
    }

        private void button4_Click(object sender, EventArgs e)
        {
            //PopulateData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    if (MessageBox.Show("Точно хотите добавить данные?", "Подтверждения действия!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("delete from Dolzhnosti where code='" + textBox1.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Ваши данные удалены ");
                        display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    if (MessageBox.Show("Точно хотите добавить данные?", "Подтверждения действия!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("update Dolzhnosti set Code='" + textBox1.Text + "', name='" + textBox2.Text + "", con);
                        //cmd = new SqlCommand("update sale set date '" + txtDate.Text + "', book_id '" + txtBookID.Text + "', number_of_instances '" + txtPages + "', payment_amount '" + txtSum + "', employee_id '" + txtEmployeeID.Text + "', orderr='" + priznak + "', orderr_number '" + txtNumOrderr + "' where id=" + id + "'", con);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(" You Data Has Been Updated ");
                        display();
                    }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
