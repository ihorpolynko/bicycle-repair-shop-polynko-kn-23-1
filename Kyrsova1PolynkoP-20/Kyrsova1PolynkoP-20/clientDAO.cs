using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Kyrsova1PolynkoP_20
{
    class clientDAO
    {
        public List<Client> clients = new List<Client>();

        public List<Client> getALLClients()
        {
            List<Client> clients = new List<Client>();
            MySqlConnection connection = new MySqlConnection(DBConfig.ConnectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from client;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Client c = new Client
                    {
                        client_id = reader.GetInt32(0),
                        client_pib = reader.IsDBNull(1) ? null : reader.GetString(1),
                        type_of_zamov = reader.IsDBNull(2) ? null : reader.GetString(2),
                    };
                    clients.Add(c);
                }
            }
            connection.Close();
            return clients;
        }

        internal int addClient(Client client)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.ConnectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into client (client_id, client_pib, type_of_zamov) values(@client_id, @client_pib, @type_of_zamov);";
            command.Parameters.AddWithValue("@client_id", client.client_id);
            command.Parameters.AddWithValue("@client_pib", client.client_pib);
            command.Parameters.AddWithValue("@type_of_zamov", client.type_of_zamov);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteClient(Client client)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.ConnectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from client WHERE (client_id = @client_id);";
            command.Parameters.AddWithValue("@client_id", client.client_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        internal int updateClient(Client client)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.ConnectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update client set client_pib = @client_pib, type_of_zamov = @type_of_zamov WHERE (client_id = @client_id);";
            command.Parameters.AddWithValue("@client_id", client.client_id);
            command.Parameters.AddWithValue("@client_pib", client.client_pib);
            command.Parameters.AddWithValue("@type_of_zamov", client.type_of_zamov);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}