using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public class DBConfig
    {
        public string DataSource { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        private static string dataSource;
        private static string username;
        private static string password;
        private static string database;

        public static string LoadConfig()
        {
            string jsonString = File.ReadAllText("dbconfig.json");

            var config = JsonSerializer.Deserialize<DBConfig>(jsonString);

            dataSource = config.DataSource;
            username = config.Username;
            password = config.Password;
            database = config.Database;

            return $"datasource={dataSource};username={username};password={password};database={database}";
        }

        public string GetConnectionString()
        {
            return $"datasource={DataSource};username={Username};password={Password};database={Database}";
        }
    }
}
