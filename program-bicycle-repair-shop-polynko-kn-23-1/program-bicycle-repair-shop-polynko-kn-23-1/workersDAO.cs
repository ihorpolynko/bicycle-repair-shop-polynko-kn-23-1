using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    internal class workersDAO
    {
        public List<Workers> workers = new List<Workers>();


        public List<Workers> getALLWorkers()
        {
            List<Workers> workers = new List<Workers>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from workers;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Workers w = new Workers
                    {
                        worker_id = reader.GetInt32(0),
                        pib = reader.GetString(1),
                        position = reader.GetString(2),
                        phone_number = reader.GetString(3),
                        salary = reader.GetDecimal(4)
                    };
                    workers.Add(w);
                }
            }
            connection.Close();
            return workers;
        }

        internal int addWorker(Workers worker)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into workers (pib, position, phone_number, salary) values(@pib, @position, @phone_number, @salary);";
            command.Parameters.AddWithValue("@pib", worker.pib);
            command.Parameters.AddWithValue("@position", worker.position);
            command.Parameters.AddWithValue("@phone_number", worker.phone_number);
            command.Parameters.AddWithValue("@salary", worker.salary);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteWorker(Workers worker)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from workers where (worker_id = @worker_id);";
            command.Parameters.AddWithValue("@worker_id", worker.worker_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateWorker(Workers worker)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update workers set pib = @pib, position = @position, phone_number = @phone_number, salary = @salary WHERE " +
                "(worker_id = @worker_id);";
            command.Parameters.AddWithValue("@worker_id", worker.worker_id);
            command.Parameters.AddWithValue("@pib", worker.pib);
            command.Parameters.AddWithValue("@position", worker.position);
            command.Parameters.AddWithValue("@phone_number", worker.phone_number);
            command.Parameters.AddWithValue("@salary", worker.salary);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Workers> getSearchWorkers(Workers worker)
        {
            List<Workers> workers = new List<Workers>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from workers where position = @position;";
            command.Parameters.AddWithValue("@position", worker.position);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Workers w = new Workers
                    {
                        worker_id = reader.GetInt32(0),
                        pib = reader.GetString(1),
                        position = reader.GetString(2),
                        phone_number = reader.GetString(3),
                        salary = reader.GetDecimal(4)
                    };
                    workers.Add(w);
                }
            }
            connection.Close();
            return workers;
        }
    }
}
