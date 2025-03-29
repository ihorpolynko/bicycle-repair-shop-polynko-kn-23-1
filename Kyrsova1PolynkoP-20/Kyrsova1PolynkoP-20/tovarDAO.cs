using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class tovarDAO
    {
        public List<Tovar> tovars = new List<Tovar>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Tovar> getALLTovars()
        {
            List<Tovar> tovars = new List<Tovar>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from tovar;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Tovar t = new Tovar
                    {
                        tovar_id = reader.GetInt32(0),
                        place_id = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                        type_of_tovar = reader.IsDBNull(2) ? null : reader.GetString(2),
                        prise_of_tovar = reader.IsDBNull(3) ? null : reader.GetInt32(3)
                    };
                    tovars.Add(t);
                }
            }
            connection.Close();
            return tovars;
        }

        internal int addTovar(int tovar_id, int place_id, String type_of_tovar, int prise_of_tovar)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into tovar (tovar_id, place_id, type_of_tovar, prise_of_tovar) values(@tovar_id, @place_id, @type_of_tovar, @prise_of_tovar);";
            command.Parameters.AddWithValue("@tovar_id", tovar_id);
            command.Parameters.AddWithValue("@place_id", place_id == 0 ? (object)DBNull.Value : place_id);
            command.Parameters.AddWithValue("@type_of_tovar", string.IsNullOrEmpty(type_of_tovar) ? (object)DBNull.Value : type_of_tovar);
            command.Parameters.AddWithValue("@prise_of_tovar", prise_of_tovar == 0 ? (object)DBNull.Value : prise_of_tovar);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteTovar(int tovar)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from tovar WHERE (tovar_id = @tovar_id);";
            command.Parameters.AddWithValue("@tovar_id", tovar);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        internal int updateTovar(Tovar tovar)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update tovar set place_id = @place_id, type_of_tovar = @type_of_tovar, prise_of_tovar = @prise_of_tovar WHERE (tovar_id = @tovar_id);";
            command.Parameters.AddWithValue("@tovar_id", tovar.tovar_id);
            command.Parameters.AddWithValue("@place_id", tovar.place_id);
            command.Parameters.AddWithValue("@type_of_tovar", tovar.type_of_tovar);
            command.Parameters.AddWithValue("@prise_of_tovar", tovar.prise_of_tovar);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
