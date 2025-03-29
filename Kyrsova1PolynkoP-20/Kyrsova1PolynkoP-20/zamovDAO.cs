using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class zamovDAO
    {
        public List<Zamov> zamovs = new List<Zamov>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Zamov> getALLZamovs()
        {
            List<Zamov> zamovs = new List<Zamov>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from zamov;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zamov z = new Zamov
                    {
                        zamov_id = reader.GetInt32(0),
                        client_id = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                        worker_id = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                        tovar_id = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                        kilkist_tovar = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
                        date_of_zamov = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5)
                    };
                    zamovs.Add(z);
                }
            }
            connection.Close();
            return zamovs;
        }

        internal int addSklad(int zamov_id, int client_id, int worker_id, int tovar_id, int kilkist_tovar, DateTime date_of_zamov)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into zamov (zamov_id, client_id, worker_id, tovar_id, kilkist_tovar, date_of_zamov) values(@zamov_id, @client_id, @worker_id, @tovar_id, @kilkist_tovar, @date_of_zamov);";
            command.Parameters.AddWithValue("@zamov_id", zamov_id);
            command.Parameters.AddWithValue("@client_id", client_id == 0 ? (object)DBNull.Value : client_id);
            command.Parameters.AddWithValue("@worker_id", worker_id == 0 ? (object)DBNull.Value : worker_id);
            command.Parameters.AddWithValue("@tovar_id", tovar_id == 0 ? (object)DBNull.Value : tovar_id);
            command.Parameters.AddWithValue("@kilkist_tovar", kilkist_tovar == 0 ? (object)DBNull.Value : kilkist_tovar);
            command.Parameters.AddWithValue("@date_of_zamov", date_of_zamov);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteZamov(int zamov)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from zamov WHERE (zamov_id = @zamov_id);";
            command.Parameters.AddWithValue("@zamov_id", zamov);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        internal int updateZamov(Zamov zamov)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update zamov set client_id = @client_id, worker_id = @worker_id, tovar_id = @tovar_id, kilkist_tovar = @kilkist_tovar, date_of_zamov = @date_of_zamov WHERE (zamov_id = @zamov_id);";
            command.Parameters.AddWithValue("@zamov_id", zamov.zamov_id);
            command.Parameters.AddWithValue("@client_id", zamov.client_id);
            command.Parameters.AddWithValue("@worker_id", zamov.worker_id);
            command.Parameters.AddWithValue("@tovar_id", zamov.tovar_id);
            command.Parameters.AddWithValue("@kilkist_tovar", zamov.kilkist_tovar);
            command.Parameters.AddWithValue("@date_of_zamov", zamov.date_of_zamov);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
