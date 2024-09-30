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
    public partial class AddEditServer : Form
    {
        public AddEditServer(string windowName, ServerTemplate server = null)
        { 
            InitializeComponent();
            this.Text = windowName;
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
    }
}
