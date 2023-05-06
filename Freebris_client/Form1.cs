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
                //HomePage homePage = new HomePage(textBox1.Text);
                //this.Hide();
                //homePage.Show();
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NOT OK");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(PassRegTextBox.Text == Pass2RegTextBox.Text)
            {
                if (!service.CreateUser(UserRegTextBox.Text, PassRegTextBox.Text,emailRegTextBox.Text))
                {
                    MessageBox.Show("Username already exits");
                }
                else
                {
                    MessageBox.Show("User created");
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
        }
    }
}
