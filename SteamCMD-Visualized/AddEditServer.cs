using System;
using System.Windows.Forms;
using SteamCMD_Visualized.Backend.Model;

namespace SteamCMD_Visualized
{
    public partial class AddEditServer : Form
    {
        private GameServers gameServers;
        private ServerTemplate existingServer;
        public event EventHandler ServerAdded;

        public AddEditServer(string windowName, GameServers gs, ServerTemplate server = null)
        {
            InitializeComponent();
            this.Text = windowName;
            gameServers = gs;
            existingServer = server;
            SetGui(server);
        }

        private void SetGui(ServerTemplate server = null)
        {
            updateFrequencyBox.Items.Add(UpdateInterval.Daily);
            updateFrequencyBox.Items.Add(UpdateInterval.Weekly);
            updateFrequencyBox.Items.Add(UpdateInterval.None);
            if (server == null)
            {
                updateFrequencyBox.Text = "Set Me";
                serverNameTextBox.Text = string.Empty;
                steamAppIDTextBox.Text = string.Empty;
                runServer.Checked = false;
            }
            else
            {
                updateFrequencyBox.Text = server.updateInterval.ToString();
                serverNameTextBox.Text = server.gameName ?? string.Empty;
                steamAppIDTextBox.Text = server.appID ?? string.Empty;
                runServer.Checked = server.serverActive;
            }
        }

        private void apply_Button_Click(object sender, EventArgs e)
        {
            UpdateInterval interval;
            Enum.TryParse(updateFrequencyBox.Text, out interval);

            if (existingServer == null)
            {
                gameServers.CreateServer(steamAppIDTextBox.Text, serverNameTextBox.Text, runServer.Checked, interval);
            }
            else
            {
                existingServer.appID = steamAppIDTextBox.Text;
                existingServer.gameName = serverNameTextBox.Text;
                existingServer.serverActive = runServer.Checked;
                existingServer.updateInterval = interval;
                gameServers.ChangeSetting(existingServer);
            }

            ServerAdded?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}