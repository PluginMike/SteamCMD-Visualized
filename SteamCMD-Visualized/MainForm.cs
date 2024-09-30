using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamCMD_Visualized.Backend.Model;

namespace SteamCMD_Visualized
{
    public partial class MainForm : Form
    {
        public GameServers gameServers = new GameServers();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void addServer_Click(object sender, EventArgs e)
        {
            AddEditServer addServer = new AddEditServer("Add Server");
            addServer.Show();
        }

        private void editServer_Click(object sender, EventArgs e)
        {
            if(serverList.Items.Count == 0)
            {
                MessageBox.Show("Please create a server first");
            }
            else
            {
                AddEditServer editServer = new AddEditServer("Edit Server");
            }
        }
    }
}
