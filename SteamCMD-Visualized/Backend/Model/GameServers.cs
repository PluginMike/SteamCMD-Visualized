using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Threading.Tasks;

namespace SteamCMD_Visualized.Backend.Model
{
    public class GameServers
    {
        List<ServerTemplate> servers;
        private const string JsonFilePath = "servers.json";
        public GameServers()
        {
            LoadServersFromJson();
        }
        public void CreateServer(string appID, string gameName, bool serverActive, UpdateInterval updateInterval)
        {
            ServerTemplate newServer = new ServerTemplate(appID, gameName, serverActive, updateInterval);
            servers.Add(newServer);
            SaveServersToJson();
        }
        public void ChangeSetting(ServerTemplate server)
        {
            ServerTemplate tempServer = servers.FirstOrDefault(s => s.appID == server.appID);
            if (tempServer != null)
            {
                tempServer.appID = server.appID;
                tempServer.gameName = server.gameName;
                tempServer.serverActive = server.serverActive;
                tempServer.updateInterval = server.updateInterval;

                // Update the server in the list
                int index = servers.FindIndex(s => s.appID == server.appID);
                if (index != -1)
                {
                    servers[index] = tempServer;
                }
            }
            else
            {
                // If the server doesn't exist in the list, add it
                servers.Add(server);
            }

            SaveServersToJson();
        }
        private void SaveServersToJson()
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    Converters = { new StringEnumConverter() }
                };

                string jsonString = JsonConvert.SerializeObject(servers, settings);
                File.WriteAllText(JsonFilePath, jsonString);
                Console.WriteLine("Servers saved to JSON file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving servers to JSON: {ex.Message}");
            }
        }

        private void LoadServersFromJson()
        {
            if (File.Exists(JsonFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(JsonFilePath);
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        Converters = { new StringEnumConverter() }
                    };

                    servers = JsonConvert.DeserializeObject<List<ServerTemplate>>(jsonString, settings);
                    Console.WriteLine("Servers loaded from JSON file successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading servers from JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No existing JSON file found. Starting with an empty server list.");
            }
        }

        public List<ServerTemplate> GetAllServers()
        {
            return new List<ServerTemplate>(servers);
        }
    }
    public enum UpdateInterval
    {
        None,Daily,Weekly
    }
}
