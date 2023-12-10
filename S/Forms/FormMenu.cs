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
    public partial class FormMenu : Form
    {
        private int tempIndex;
        private Random random;
        private Button currentButton;
        private object panelTitleBar;
        private object activeForm;
        private object panelDesktop;

        public FormMenu()
        {
            InitializeComponent();
            random = new Random();
        }
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC\AKHATSQLSERVER;Initial Catalog=uchebnaya_nagruzka;Integrated Security=True");

        

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
 
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Discipliny(), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Vidy_uchebnoi_nagruzki(), sender);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Dolzhnosti(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Dopustimye_vidy_nagruzki(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Gruppy(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Kafedry(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Normativ(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Prepodavateli(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Table_Nagruzka(), sender);
        }
    }
}
