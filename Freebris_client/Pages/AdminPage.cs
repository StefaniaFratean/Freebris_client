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
    public partial class AdminPage : UserControl
    {
        string username;
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();

        public AdminPage(string username)
        {
            InitializeComponent();
            this.username = username;
            points.Text = service.GetPoints(username).ToString();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            DataTable users = service.GetAllUsers();
            DisplayUsers(users);
        }

        private void RefreshPage()
        {
            this.Show();
            this.Controls.Clear();
            InitializeComponent();
            points.Text = service.GetPoints(username).ToString();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }


        private void DisplayUsers(DataTable users)
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = true;
            if (users.Rows.Count == 0)
            {
                Label message = new Label();
                message.Text = "No users to be shown!";
                message.Location = new Point(0, 100);
                message.Size = new Size(100, 30);
                message.Visible = true;

                panel1.Controls.Add(message);
                return;
            }

            int y = 0;
            for (int i = 0; i < users.Rows.Count; i++)
            {
                Button book = new Button();
                book.Name = users.Rows[i]["username"].ToString();
                book.Size = new Size(200, 200);
                string file = service.GetIconBook(int.Parse(users.Rows[i]["idIcon"].ToString()));
                book.BackgroundImage = Image.FromFile(file);
                book.BackgroundImageLayout = ImageLayout.Stretch;
                book.Visible = true;
                book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                book.Location = new Point(120, y);

                Label tb = new Label();
                tb.Text = users.Rows[i]["username"].ToString();
                tb.Location = new Point(350, y);
                tb.Visible = true;

                Button delete = new Button();
                delete.Name = users.Rows[i]["id"].ToString();
                delete.Size = new Size(80, 40);
                delete.Text = "Remove";
                delete.Visible = true;
                delete.Location = new Point(0, y + 20);
                delete.Click += new EventHandler(Delete_Click);

                panel1.Controls.Add(book);
                panel1.Controls.Add(tb);
                panel1.Controls.Add(delete);

                y += 250;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this account?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Button btn = (Button)sender;
                service.DeleteUser(int.Parse(btn.Name));
                MessageBox.Show("The account had been deleted");
                DataTable users = service.GetAllUsers();
                DisplayUsers(users);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
