using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Collections.Generic;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    class clientsDAO
    {
        public List<Clients> clients = new List<Clients>();


        public List<Clients> getALLClients()
        {
            List<Clients> clients = new List<Clients>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from clients;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Clients c = new Clients
                    {
                        client_id = reader.GetInt32(0),
                        pib = reader.GetString(1),
                        phone_number = reader.GetString(2),
                    };
                    clients.Add(c);
                }
            }
            connection.Close();
            return clients;
        }

        internal int addClient(Clients client)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into clients (pib, phone_number) values(@pib, @phone_number);";
            command.Parameters.AddWithValue("@pib", client.pib);
            command.Parameters.AddWithValue("@phone_number", client.phone_number);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteClient(Clients client)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from clients where (client_id = @client_id);";
            command.Parameters.AddWithValue("@client_id", client.client_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateClient(Clients client)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update clients set pib = @pib, phone_number = @phone_number WHERE (client_id = @client_id);";
            command.Parameters.AddWithValue("@client_id", client.client_id);
            command.Parameters.AddWithValue("@pib", client.pib);
            command.Parameters.AddWithValue("@phone_number", client.phone_number);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Clients> getSearchClients(Clients client)
        {
            List<Clients> clients = new List<Clients>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from clients where pib = @pib;";
            command.Parameters.AddWithValue("@pib", client.pib);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Clients c = new Clients
                    {
                        client_id = reader.GetInt32(0),
                        pib = reader.GetString(1),
                        phone_number = reader.GetString(2),
                    };
                    clients.Add(c);
                }
            }
            connection.Close();
            return clients;
        }
    }
}