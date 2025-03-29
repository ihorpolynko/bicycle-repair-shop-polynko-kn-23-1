using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    internal class workerDAO
    {
        public List<Worker> workers = new List<Worker>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Worker> getALLWorkers()
        {
            List<Worker> workers = new List<Worker>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from worker;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Worker w = new Worker
                    {
                        worker_id = reader.GetInt32(0),
                        worker_pib = reader.IsDBNull(1) ? null : reader.GetString(1),
                        worker_posada = reader.IsDBNull(2) ? null : reader.GetString(2),
                        zarplata_worker = reader.IsDBNull(3) ? (double?)null : reader.GetDouble(3),
                    };
                    workers.Add(w);
                }
            }
            connection.Close();
            return workers;
        }

        internal int addWorker(int worker_id, String worker_pib, String worker_posada, double zarplata_worker)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into worker (worker_id, worker_pib, worker_posada, zarplata_worker) values(@worker_id, @worker_pib, @worker_posada, @zarplata_worker);";
            command.Parameters.AddWithValue("@worker_id", worker_id);
            command.Parameters.AddWithValue("@worker_pib", string.IsNullOrEmpty(worker_pib) ? (object)DBNull.Value : worker_pib);
            command.Parameters.AddWithValue("@worker_posada", string.IsNullOrEmpty(worker_posada) ? (object)DBNull.Value : worker_posada);
            command.Parameters.AddWithValue("@zarplata_worker", zarplata_worker == 0 ? (object)DBNull.Value : zarplata_worker);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteWorker(int worker)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from worker WHERE (worker_id = @worker_id);";
            command.Parameters.AddWithValue("@worker_id", worker);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        internal int updateWorker(Worker worker)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update worker set worker_pib = @worker_pib, worker_posada = @worker_posada, zarplata_worker = @zarplata_worker WHERE (worker_id = @worker_id);";
            command.Parameters.AddWithValue("@worker_id", worker.worker_id);
            command.Parameters.AddWithValue("@worker_pib", worker.worker_id);
            command.Parameters.AddWithValue("@worker_posada", worker.worker_posada);
            command.Parameters.AddWithValue("@zarplata_worker", worker.zarplata_worker);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
