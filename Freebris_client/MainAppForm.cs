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
        public MainAppForm(string username)
        {
            this.username = username;
            InitializeComponent();
            InitializeNavigationController();
        }

        private void InitializeNavigationController()
        {
            List<UserControl> pages = new List<UserControl>()
            {
                new MainPage(username),
                new SettingsPage(username)
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
    }
}
