using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    internal class skladDAO
    {
        public List<Sklad> sklads = new List<Sklad>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Sklad> getALLSklads()
        {
            List<Sklad> sklads = new List<Sklad>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from sklad;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Sklad s = new Sklad
                    {
                        place_id = reader.GetInt32(0),
                        sklad_id = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                        tovar_id = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                        type_of_tovar = reader.IsDBNull(3) ? null : reader.GetString(3),
                        nayavnist = reader.IsDBNull(4) ? null : reader.GetString(4),
                        kilkist_tovar = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5)
                    };
                    sklads.Add(s);
                }
            }
            connection.Close();
            return sklads;
        }

        internal int addSklad(int place_id, int sklad_id, int tovar_id, String type_of_tovar, String nayavnist, int kilkist_tovar)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into sklad (place_id, sklad_id, tovar_id, type_of_tovar, nayavnist, kilkist_tovar) values(@place_id, @sklad_id, @tovar_id, @type_of_tovar, @nayavnist, @kilkist_tovar);";
            command.Parameters.AddWithValue("@place_id", place_id);
            command.Parameters.AddWithValue("@sklad_id", sklad_id == 0 ? (object)DBNull.Value : sklad_id);
            command.Parameters.AddWithValue("@tovar_id", tovar_id == 0 ? (object)DBNull.Value : tovar_id);
            command.Parameters.AddWithValue("@type_of_tovar", string.IsNullOrEmpty(type_of_tovar) ? (object)DBNull.Value : type_of_tovar);
            command.Parameters.AddWithValue("@nayavnist", string.IsNullOrEmpty(nayavnist) ? (object)DBNull.Value : nayavnist);
            command.Parameters.AddWithValue("@kilkist_tovar", kilkist_tovar == 0 ? (object)DBNull.Value : kilkist_tovar);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteSklad(int sklad)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from sklad WHERE (place_id = @place_id);";
            command.Parameters.AddWithValue("@place_id", sklad);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        internal int updateSklad(Sklad sklad)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update sklad set sklad_id = @sklad_id, tovar_id = @tovar_id, type_of_tovar = @type_of_tovar, nayavnist = @nayavnist, kilkist_tovar = @kilkist_tovar WHERE (place_id = @place_id);";
            command.Parameters.AddWithValue("@place_id", sklad.place_id);
            command.Parameters.AddWithValue("@sklad_id", sklad.sklad_id);
            command.Parameters.AddWithValue("@tovar_id", sklad.tovar_id);
            command.Parameters.AddWithValue("@type_of_tovar", sklad.type_of_tovar);
            command.Parameters.AddWithValue("@nayavnist", sklad.nayavnist);
            command.Parameters.AddWithValue("@kilkist_tovar", sklad.kilkist_tovar);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
