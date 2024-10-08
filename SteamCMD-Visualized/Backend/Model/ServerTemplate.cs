using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SteamCMD_Visualized.Backend.Model
{
    public class ServerTemplate
    {
        public string appID;
        public string gameName;
        public bool serverActive;
        public UpdateInterval updateInterval;

        [JsonConstructor]
        public ServerTemplate(string appID, string gameName, bool serverActive, UpdateInterval updateInterval)
        {
            this.appID = appID;
            this.gameName = gameName;
            this.serverActive = serverActive;
            this.updateInterval = updateInterval;
        }
    }

}
