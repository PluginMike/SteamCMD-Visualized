using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SteamCMD_Visualized.Backend.Model
{
    public class GameServers
    {
        private List<ServerTemplate> servers;
        private readonly string jsonFilePath;

        public GameServers()
        {
            servers = new List<ServerTemplate>(); // Initialize the list
            jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servers.json");
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
            int index = servers.FindIndex(s => s.appID == server.appID);
            if (index != -1)
            {
                servers[index] = server;
            }
            else
            {
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
                File.WriteAllText(jsonFilePath, jsonString);
                Console.WriteLine($"Servers saved to JSON file successfully at: {jsonFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving servers to JSON: {ex.Message}");
            }
        }

        private void LoadServersFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(jsonFilePath);
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        Converters = { new StringEnumConverter() }
                    };
                    servers = JsonConvert.DeserializeObject<List<ServerTemplate>>(jsonString, settings) ?? new List<ServerTemplate>();
                    Console.WriteLine($"Servers loaded from JSON file successfully from: {jsonFilePath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading servers from JSON: {ex.Message}");
                    servers = new List<ServerTemplate>(); // Ensure we have an empty list if loading fails
                }
            }
            else
            {
                Console.WriteLine($"No existing JSON file found at {jsonFilePath}. Starting with an empty server list.");
                servers = new List<ServerTemplate>();
            }
        }

        public List<ServerTemplate> GetAllServers()
        {
            return new List<ServerTemplate>(servers);
        }
    }

    public enum UpdateInterval
    {
        None,
        Daily,
        Weekly
    }
}