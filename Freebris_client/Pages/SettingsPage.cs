using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freebris_client.Pages
{
    public partial class SettingsPage : UserControl
    {
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();
        string username;
        public SettingsPage(string username)
        {
            this.Show();
            this.username = username;
            InitializeComponent();
            tableLayoutPanelChangePass.Hide();
            tableLayoutPanelChangeEmail.Hide();
            ConfirmButton.Hide();
        }

        // change password
        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanelChangePass.Show();
            tableLayoutPanelChangeEmail.Hide();
            ConfirmButton.Show();

        }
        // change email
        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanelChangePass.Hide();
            tableLayoutPanelChangeEmail.Show();
            ConfirmButton.Show();
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(tableLayoutPanelChangeEmail.Visible == true)
            {

            }
            else if(tableLayoutPanelChangePass.Visible == true)
            {
                if(textBox2.Text == textBox3.Text)
                {
                    if(textBox1.Text != textBox3.Text)
                    {
                        service.ChangePassword(username, textBox3.Text);
                    }
                    else
                    {
                        MessageBox.Show("The new password is the same as the old one!");
                    }
                }
                else
                {
                    MessageBox.Show("The passwords are not the same!");
                }
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = service.GetId(username, "Users");
                service.DeleteUser(id);
                MessageBox.Show("Your account had been deleted");
                // Logout!!!!!!!!!!!
            }
        }

    }
}
