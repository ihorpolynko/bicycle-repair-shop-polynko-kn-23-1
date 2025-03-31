using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class zapus_na_remontDAO
    {
        public List<Zapus_na_remont> zapus_na_remonts = new List<Zapus_na_remont>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Zapus_na_remont> getALLZapus_na_remonts()
        {
            List<Zapus_na_remont> zapus_na_remonts = new List<Zapus_na_remont>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from zapus_na_remont;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zapus_na_remont z = new Zapus_na_remont
                    {
                        zapus_na_remont_id = reader.GetInt32(0),
                        client_id = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                        master_id = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                        reason_of_remont = reader.IsDBNull(3) ? null : reader.GetString(3),
                        remont_date = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                        oplata = reader.IsDBNull(5) ? (double?)null : reader.GetInt32(5),
                    };
                    zapus_na_remonts.Add(z);
                }
            }
            connection.Close();
            return zapus_na_remonts;
        }

        internal int addZapus_na_remont(int zapus_na_remont_id, int client_id, int master_id, String reason_of_remont, DateTime remont_date, double oplata)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into zapus_na_remont (zapus_na_remont_id, client_id, master_id, reason_of_remont, remont_date, oplata) values(@zapus_na_remont_id, @client_id, @master_id, @reason_of_remont, @remont_date, @oplata);";
            command.Parameters.AddWithValue("@zapus_na_remont_id", zapus_na_remont_id);
            command.Parameters.AddWithValue("@client_id", client_id == 0 ? (object)DBNull.Value : client_id);
            command.Parameters.AddWithValue("@master_id", master_id == 0 ? (object)DBNull.Value : master_id);
            command.Parameters.AddWithValue("@reason_of_remont", reason_of_remont);
            command.Parameters.AddWithValue("@remont_date", remont_date);
            command.Parameters.AddWithValue("@oplata", oplata == 0 ? (object)DBNull.Value : oplata);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteZapus_na_remont(int zapus_na_remont)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from zapus_na_remont WHERE (zapus_na_remont_id = @zapus_na_remont_id);";
            command.Parameters.AddWithValue("@zapus_na_remont_id", zapus_na_remont);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateZapus_na_remont(Zapus_na_remont zapus_na_remont)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update zapus_na_remont set client_id = @client_id, master_id = @master_id, reason_of_remont = @reason_of_remont, remont_date = @remont_date, " +
                "oplata = @oplata WHERE (zapus_na_remont_id = @zapus_na_remont_id);";
            command.Parameters.AddWithValue("@zapus_na_remont_id", zapus_na_remont.zapus_na_remont_id);
            command.Parameters.AddWithValue("@client_id", zapus_na_remont.client_id);
            command.Parameters.AddWithValue("@master_id", zapus_na_remont.master_id);
            command.Parameters.AddWithValue("@reason_of_remont", zapus_na_remont.reason_of_remont);
            command.Parameters.AddWithValue("@remont_date", zapus_na_remont.remont_date);
            command.Parameters.AddWithValue("@oplata", zapus_na_remont.oplata);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
