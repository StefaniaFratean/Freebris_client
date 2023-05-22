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
    public partial class Login : Form
    {
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();

        Register register = new Register();
        
        public Login()
        {
            InitializeComponent();
            usernameLogTextBox.Cursor = Cursors.Arrow;
            
            
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
     

        
        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            if (service.CheckPassword(usernameLogTextBox.Text, PassLogTextBox.Text))
            {
                string typeAcc;
                if (service.IsAdmin(usernameLogTextBox.Text))
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


        private void usernameLogTextBox_Click(object sender, EventArgs e)
        {
            usernameLogTextBox.Text = "";

        }

        private void PassLogTextBox_Click(object sender, EventArgs e)
        {
            PassLogTextBox.Text = "";
        }

        private void usernameLogTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            register.Show();
            

        }
    }
}
