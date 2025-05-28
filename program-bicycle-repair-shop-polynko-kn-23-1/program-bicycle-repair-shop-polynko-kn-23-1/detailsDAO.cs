using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Collections.Generic;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    class detailsDAO
    {
        public List<Details> details = new List<Details>();

        public List<Details> getALLDetails()
        {
            List<Details> details = new List<Details>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from details;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Details d = new Details
                    {
                        detail_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                    };
                    details.Add(d);
                }
            }
            connection.Close();
            return details;
        }

        internal int addDetail(Details detail)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into details (name, price) values(@name, @price);";
            command.Parameters.AddWithValue("@name", detail.name);
            command.Parameters.AddWithValue("@price", detail.price);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteDetail(Details detail)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from details where (detail_id = @detail_id);";
            command.Parameters.AddWithValue("@detail_id", detail.detail_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateDetail(Details detail)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update details set name = @name, price = @price WHERE (detail_id = @detail_id);";
            command.Parameters.AddWithValue("@detail_id", detail.detail_id);
            command.Parameters.AddWithValue("@name", detail.name);
            command.Parameters.AddWithValue("@price", detail.price);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Details> getSearchDetails(Details detail)
        {
            List<Details> s = new List<Details>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from details where name = @name;";
            command.Parameters.AddWithValue("@name", detail.name);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Details d = new Details
                    {
                        detail_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                    };
                    details.Add(d);
                }
            }
            connection.Close();
            return details;
        }
    }
}