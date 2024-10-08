using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SteamCMD_Visualized.Backend.Model;

namespace SteamCMD_Visualized
{
    public partial class MainForm : Form
    {
        private GameServers gameServers;
        private List<ServerTemplate> server_List;

        public MainForm()
        {
            InitializeComponent();
            gameServers = new GameServers();
        }

        private void addServer_Click(object sender, EventArgs e)
        {
            AddEditServer addServer = new AddEditServer("Add Server", gameServers);
            addServer.ServerAdded += ServerAddedOrEdited;
            addServer.ShowDialog();
        }

        private void editServer_Click(object sender, EventArgs e)
        {
            if (serverList.Items.Count == 0 || serverList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a server to edit.");
            }
            else
            {
                ServerTemplate selected_server = server_List[serverList.SelectedIndex];
                AddEditServer editServer = new AddEditServer("Edit Server", gameServers, selected_server);
                editServer.ServerAdded += ServerAddedOrEdited;
                editServer.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshServerList();
        }

        private void ServerAddedOrEdited(object sender, EventArgs e)
        {
            RefreshServerList();
        }

        private void RefreshServerList()
        {
            serverList.Items.Clear();
            server_List = gameServers.GetAllServers();
            foreach (var server in server_List)
            {
                serverList.Items.Add(server.gameName);
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            if (serverList.Items.Count == 0 || serverList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a server to delete.");
            }
            else
            {
                //TODO: Implement Deletion logic

                RefreshServerList();
            }
        }
    }
}