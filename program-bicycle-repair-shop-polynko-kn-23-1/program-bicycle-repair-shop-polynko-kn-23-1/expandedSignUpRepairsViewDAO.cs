using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    internal class expandedSignUpRepairsViewDAO
    {
        public List<ExpandedSignUpRepairsView> expandedSignUpRepairsView = new List<ExpandedSignUpRepairsView>();

        public List<ExpandedSignUpRepairsView> getALLexpandedSignUpRepairsView()
        {
            List<ExpandedOrderDetailView> expandedOrderDetailViews = new List<ExpandedOrderDetailView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from expanded_sign_up_repairs;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedSignUpRepairsView esur = new ExpandedSignUpRepairsView
                    {
                        sign_up_repairs_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        sign_up_date = reader.GetDateTime(3),
                        payment_amount = reader.GetDecimal(4)
                    };
                    expandedSignUpRepairsView.Add(esur);
                }
            }
            connection.Close();
            return expandedSignUpRepairsView;
        }

        public List<ExpandedSignUpRepairsView> getSearchByID(ExpandedSignUpRepairsView expandedSignUpRepairView)
        {
            List<ExpandedSignUpRepairsView> expandedSignUpRepairsView = new List<ExpandedSignUpRepairsView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from expanded_sign_up_repairs where sign_up_repairs_id = @sign_up_repairs_id;";
            command.Parameters.AddWithValue("@sign_up_repairs_id", expandedSignUpRepairView.sign_up_repairs_id);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedSignUpRepairsView esur = new ExpandedSignUpRepairsView
                    {
                        sign_up_repairs_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        sign_up_date = reader.GetDateTime(3),
                        payment_amount = reader.GetDecimal(4)
                    };
                    expandedSignUpRepairsView.Add(esur);
                }
            }
            connection.Close();
            return expandedSignUpRepairsView;
        }

        public List<ExpandedSignUpRepairsView> getSearchByWorkerPIB(ExpandedSignUpRepairsView expandedSignUpRepairView)
        {
            List<ExpandedSignUpRepairsView> expandedSignUpRepairsView = new List<ExpandedSignUpRepairsView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from expanded_sign_up_repairs where worker_pib = @worker_pib;";
            command.Parameters.AddWithValue("@worker_pib", expandedSignUpRepairView.worker_pib);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedSignUpRepairsView esur = new ExpandedSignUpRepairsView
                    {
                        sign_up_repairs_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        sign_up_date = reader.GetDateTime(3),
                        payment_amount = reader.GetDecimal(4)
                    };
                    expandedSignUpRepairsView.Add(esur);
                }
            }
            connection.Close();
            return expandedSignUpRepairsView;
        }

        public List<ExpandedSignUpRepairsView> getSearchByClientPIB(ExpandedSignUpRepairsView expandedSignUpRepairView)
        {
            List<ExpandedSignUpRepairsView> expandedSignUpRepairsView = new List<ExpandedSignUpRepairsView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from expanded_sign_up_repairs where client_pib = @client_pib;";
            command.Parameters.AddWithValue("@client_pib", expandedSignUpRepairView.client_pib);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedSignUpRepairsView esur = new ExpandedSignUpRepairsView
                    {
                        sign_up_repairs_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        sign_up_date = reader.GetDateTime(3),
                        payment_amount = reader.GetDecimal(4)
                    };
                    expandedSignUpRepairsView.Add(esur);
                }
            }
            connection.Close();
            return expandedSignUpRepairsView;
        }
    }
}