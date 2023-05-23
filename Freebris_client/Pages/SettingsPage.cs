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
        string typeAcc;
        public SettingsPage(string username, string typeAcc)
        {
            this.Show();
            this.username = username;
            this.typeAcc = typeAcc;
            InitializeComponent();
            tableLayoutPanelChangePass.Hide();
            tableLayoutPanelChangeEmail.Hide();
            ConfirmButton.Hide();
            points.Text = service.GetPoints(username).ToString();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }

        // change password
        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanelChangePass.Show();
            tableLayoutPanelChangeEmail.Hide();
            IconPanel.Visible = false;
            ConfirmButton.Show();

        }
        // change email
        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanelChangePass.Hide();
            tableLayoutPanelChangeEmail.Show();
            IconPanel.Visible = false;
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
                        MessageBox.Show("The password is changed!");
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
            else if(IconPanel.Visible == true)
            {

            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = service.GetId(username);
                service.DeleteUser(id);
                MessageBox.Show("Your account had been deleted");
                // Logout!!!!!!!!!!!
            }
        }

        private void IconButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanelChangeEmail.Visible = false;
            tableLayoutPanelChangePass.Visible = false;
            IconPanel.Visible = true;
            ConfirmButton.Visible = false;
            LoadIconPanel();
        }

        private void LoadIconPanel()
        {
            IconPanel.Controls.Clear();
            DataTable icons = service.GetAllIcons();
            int y = 0;
            for(int i= 0;i < icons.Rows.Count;i++)
            {
                Button icon = new Button();
                icon.Name = icons.Rows[i]["id"].ToString();
                icon.Size = new Size(100, 100);
                string file = icons.Rows[i]["imgpath"].ToString();
                icon.BackgroundImage = Image.FromFile(file);
                icon.BackgroundImageLayout = ImageLayout.Stretch;
                icon.Visible = true;
                icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                icon.Location = new Point(120, y);
                icon.Click += new EventHandler(Icon_Click);
                y += 150;

                IconPanel.Controls.Add(icon);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to pick this profile icon?", "Icon",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Button btn = (Button)sender;
                if (btn != null)
                {
                    int id = service.GetId(username);
                    service.SetIcon(id, int.Parse(btn.Name));
                    MessageBox.Show("Your icon had been set! ");
                    RefreshPage();
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void RefreshPage()
        {
            this.Show();
            this.Controls.Clear();
            InitializeComponent();
            tableLayoutPanelChangePass.Hide();
            tableLayoutPanelChangeEmail.Hide();
            ConfirmButton.Hide();
            points.Text = service.GetPoints(username).ToString();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);

        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void points_Click(object sender, EventArgs e)
        {

        }
    }
}
