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
    public partial class Form1 : Form
    {
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {                
            if (service.CheckPassword(usernameLogTextBox.Text, PassLogTextBox.Text))
            {
                string typeAcc;
                if(service.IsAdmin(usernameLogTextBox.Text))
                {
                    typeAcc = "admin";
                }
                else
                {
                    typeAcc = "classic";
                }

                MainAppForm homePage = new MainAppForm(usernameLogTextBox.Text, typeAcc);
                this.Hide();
                homePage.Show();
                //MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NOT OK");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (PassRegTextBox.Text == Pass2RegTextBox.Text && emailRegTextBox.Text == email2RegTextBox.Text)
            {
                if (!service.CreateUser(UserRegTextBox.Text, PassRegTextBox.Text, emailRegTextBox.Text))
                {
                    MessageBox.Show("Username already exits");
                }
                else
                {
                    MessageBox.Show("User created");
                    this.Hide();
                    
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LayoutOverall_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
