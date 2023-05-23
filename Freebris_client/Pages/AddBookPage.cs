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
    public partial class AddBookPage : UserControl
    {
        string username;
        string typeAcc;
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();
        public AddBookPage(string username, string typeAcc)
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            this.username = username;
            this.typeAcc = typeAcc;
            points.Text = service.GetPoints(username).ToString();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
            LoadIconPanel();

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
        // browse
        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Multiselect = false;
                openFileDialog1.Title = "Freebris - Open File";
                openFileDialog1.InitialDirectory = @"D:\FreebrisPDF";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string pathName = openFileDialog1.FileName;
                    textBox1.Text = pathName;
                }
            }
            catch(Exception)
            {
            }
        }

        private void LoadIconPanel()
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = true;
            DataTable icons = service.GetAllBookIcons();
            int y = 0;
            for (int i = 0; i < icons.Rows.Count; i++)
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

                panel1.Controls.Add(icon);
            }
        }
        private void Icon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to pick this book cover? After you pick the book will be uploaded.", "Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Button btn = (Button)sender;
                    if (btn != null)
                    {
                        int idUser = service.GetId(username);
                        service.CreateBook(textBox2.Text, 0, idUser, int.Parse(btn.Name), textBox1.Text);
                        MessageBox.Show("Your book had been uploaded! ");
                        service.AddPoints(idUser, 20);
                        RefreshPage();
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a pdf and a title first!");
            }
        }

        private void AddBookPage_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void points_Click(object sender, EventArgs e)
        {

        }
    }
}
