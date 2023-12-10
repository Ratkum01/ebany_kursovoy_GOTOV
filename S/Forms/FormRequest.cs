using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.Forms
{
    public partial class FormRequest : Form
    {
        private object random;
        private int tempIndex;
        private Button currentButton;
        private object activeForm;

        public FormRequest()
        {
            InitializeComponent();
        }


     
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Request_1 hr = new Forms.Request_1();
            hr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Request_2 hr = new Forms.Request_2();
            hr.Show();
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Request_3 hr = new Forms.Request_3();
            hr.Show();
            //OpenChildForm(new Forms.Request_3(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Request_4 hr = new Forms.Request_4();
            hr.Show();
            //OpenChildForm(new Forms.Request_4(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Request_5 hr = new Forms.Request_5();
            hr.Show();
            //OpenChildForm(new Forms.Request_5(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 hr =  new  MainForm1 ();
            hr.Show();
            this.Close();
        }
    }
}
