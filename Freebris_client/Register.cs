using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freebris_client
{
    public partial class Register : Form
    {
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

            if (PassRegTextBox.Text == Pass2RegTextBox.Text && emailRegTextBox.Text == email2RegTextBox.Text)
            {
                if (!service.CreateUser(UserRegTextBox.Text, PassRegTextBox.Text, emailRegTextBox.Text))
                {
                    MessageBox.Show("Username already exits");
                }
                else
                {
                    MainAppForm homePage = new MainAppForm(UserRegTextBox.Text, "classic");
                    MessageBox.Show("User created");
                    this.Hide();
                    homePage.Show();
                }
            }
            else
            {
                if (PassRegTextBox.Text == Pass2RegTextBox.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                }
                else
                {
                    MessageBox.Show("Emails do not match!");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserRegTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserRegTextBox_Click(object sender, EventArgs e)
        {
            UserRegTextBox.Text = "";
        }

        private void emailRegTextBox_Click(object sender, EventArgs e)
        {
            emailRegTextBox.Text = "";
        }

        private void email2RegTextBox_Click(object sender, EventArgs e)
        {
            email2RegTextBox.Text = "";
        }

        private void PassRegTextBox_Click(object sender, EventArgs e)
        {
            PassRegTextBox.Text = "";
        }

        private void Pass2RegTextBox_Click(object sender, EventArgs e)
        {
            Pass2RegTextBox.Text = "";
        }
    }
}
