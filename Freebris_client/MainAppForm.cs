using Freebris_client.Pages;
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
    public partial class MainAppForm : Form
    {
        NavigationController navigationController;
        string username;
        string typeAcc;
        public MainAppForm(string username, string typeAcc)
        {
            this.username = username;
            this.typeAcc = typeAcc;
            InitializeComponent();
            InitializeNavigationController();
            if(typeAcc != "admin")
            {
                AdminButton.Visible = false;
            }
        }

        private void InitializeNavigationController()
        {
            List<UserControl> pages = new List<UserControl>()
            {
                new MainPage(username, typeAcc),
                new SettingsPage(username, typeAcc),
                new YourBooksPage(username, typeAcc),
                new YourDownloadsPage(username, typeAcc),
                new AddBookPage(username, typeAcc),
                new AdminPage(username)

                // more pages to add
            };

            navigationController = new NavigationController(pages, panel1);
            navigationController.Display(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigationController.Display(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigationController.Display(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigationController.Display(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            navigationController.Display(3);
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            navigationController.Display(4);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            navigationController.Display(5);
        }
    }
}
