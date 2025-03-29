using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class masterDAO
    {
        public List<Master> masters = new List<Master>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Master> getALLMasters()
        {
            List<Master> masters = new List<Master>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from master;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Master m = new Master
                    {
                        master_id = reader.GetInt32(0),
                        master_pib = reader.IsDBNull(1) ? null : reader.GetString(1),
                    };
                    masters.Add(m);
                }
            }
            connection.Close();
            return masters;
        }

        internal int addMaster(Master master)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into master (master_id, master_pib) values(@master_id, @master_pib);";
            command.Parameters.AddWithValue("@master_id", master.master_id);
            command.Parameters.AddWithValue("@master_pib", master.master_pib);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteMaster(Master master)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from master WHERE (master_id = @master_id);";
            command.Parameters.AddWithValue("@master_id", master.master_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateMaster(Master master)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update master set master_pib = @master_pib WHERE (master_id = @master_id);";
            command.Parameters.AddWithValue("@master_id", master.master_id);
            command.Parameters.AddWithValue("@master_pib", master.master_pib);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
