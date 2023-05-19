using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freebris_client
{
    class NavigationController
    {
        List<UserControl> pageList = new List<UserControl>();
        Panel panel;

        public NavigationController(List<UserControl> pageList, Panel panel)
        {
            this.pageList = pageList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < pageList.Count(); i++)
            {
                pageList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(pageList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < pageList.Count())
            {
                pageList[index].BringToFront();
            }
        }

    }
}
