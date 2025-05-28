using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    internal class signuprepairsDAO
    {
        public List<SignUpRepairs> signUpRepairs = new List<SignUpRepairs>();

        public List<SignUpRepairs> getALLSignUpRepairs()
        {
            List<SignUpRepairs> signUpRepairs = new List<SignUpRepairs>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from sign_up_repairs;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SignUpRepairs sur = new SignUpRepairs
                    {
                        sign_up_repairs_id = reader.GetInt32(0),
                        worker_id = reader.GetInt32(1),
                        client_id = reader.GetInt32(2),
                        repair_reason = reader.GetString(3),
                        sign_up_date = reader.GetDateTime(4),
                        payment_amount = reader.IsDBNull(5) ? (decimal?)null : reader.GetDecimal(5),
                        payment_date = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6),
                    };
                    signUpRepairs.Add(sur);
                }
            }
            connection.Close();
            return signUpRepairs;
        }

        internal int addSignUpRepairs(SignUpRepairs signUpRepair)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into sign_up_repairs (worker_id, client_id, repair_reason, sign_up_date, " +
                "payment_amount) values(@worker_id, @client_id, @repair_reason, @sign_up_date, " +
                "@payment_amount);";
            command.Parameters.AddWithValue("@worker_id", signUpRepair.worker_id);
            command.Parameters.AddWithValue("@client_id", signUpRepair.client_id);
            command.Parameters.AddWithValue("@repair_reason", signUpRepair.repair_reason);
            command.Parameters.AddWithValue("@sign_up_date", signUpRepair.sign_up_date);
            command.Parameters.AddWithValue("@payment_amount", signUpRepair.payment_amount);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteSignUpRepairs(SignUpRepairs signUpRepair)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from sign_up_repairs where (sign_up_repairs_id = @sign_up_repairs_id);";
            command.Parameters.AddWithValue("@sign_up_repairs_id", signUpRepair.sign_up_repairs_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateSignUpRepairs(SignUpRepairs signUpRepair)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update sign_up_repairs set worker_id = @worker_id, client_id = @client_id, repair_reason = @repair_reason, " +
                "sign_up_date = @sign_up_date, payment_amount = @payment_amount, payment_date = @payment_date WHERE (sign_up_repairs_id = @sign_up_repairs_id);";
            command.Parameters.AddWithValue("@sign_up_repairs_id", signUpRepair.sign_up_repairs_id);
            command.Parameters.AddWithValue("@worker_id", signUpRepair.worker_id);
            command.Parameters.AddWithValue("@client_id", signUpRepair.client_id);
            command.Parameters.AddWithValue("@repair_reason", signUpRepair.repair_reason);
            command.Parameters.AddWithValue("@sign_up_date", signUpRepair.sign_up_date);
            command.Parameters.AddWithValue("@payment_amount", signUpRepair.payment_amount);
            command.Parameters.AddWithValue("@payment_date", signUpRepair.payment_date);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<SignUpRepairs> getSearchSignUpRepairs(SignUpRepairs signUpRepair)
        {
            List<SignUpRepairs> signUpRepairs = new List<SignUpRepairs>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from sign_up_repairs where client_id = @client_id;";
            command.Parameters.AddWithValue("@client_id", signUpRepair.client_id);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SignUpRepairs sur = new SignUpRepairs
                    {
                        sign_up_repairs_id = reader.GetInt32(0),
                        worker_id = reader.GetInt32(1),
                        client_id = reader.GetInt32(2),
                        repair_reason = reader.GetString(3),
                        sign_up_date = reader.GetDateTime(4),
                        payment_amount = reader.IsDBNull(5) ? (decimal?)null : reader.GetDecimal(5),
                        payment_date = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6),
                    };
                    signUpRepairs.Add(sur);
                }
            }
            connection.Close();
            return signUpRepairs;
        }
    }
}