using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    internal class expandedOrderDetailViewDAO
    {
        public List<ExpandedOrderDetailView> expandedOrderDetailView = new List<ExpandedOrderDetailView>();


        public List<ExpandedOrderDetailView> getALLexpandedOrderDetailView()
        {
            List<ExpandedOrderDetailView> expandedOrderDetailViews = new List<ExpandedOrderDetailView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from expanded_order_detail;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedOrderDetailView eod = new ExpandedOrderDetailView
                    {
                        order_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        order_date = reader.GetDateTime(3),
                        detail_name = reader.GetString(4),
                        quantity = reader.GetInt32(5),
                        total_price = reader.GetDecimal(6)
                    };
                    expandedOrderDetailViews.Add(eod);
                }
            }
            connection.Close();
            return expandedOrderDetailViews;
        }

        public List<ExpandedOrderDetailView> getSearchByID(ExpandedOrderDetailView expandedOrderDetailView)
        {
            List<ExpandedOrderDetailView> expandedOrderDetailViews = new List<ExpandedOrderDetailView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from expanded_order_detail where order_id = @order_id;";
            command.Parameters.AddWithValue("@order_id", expandedOrderDetailView.order_id);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedOrderDetailView eod = new ExpandedOrderDetailView
                    {
                        order_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        order_date = reader.GetDateTime(3),
                        detail_name = reader.GetString(4),
                        quantity = reader.GetInt32(5),
                        total_price = reader.GetDecimal(6)
                    };
                    expandedOrderDetailViews.Add(eod);
                }
            }
            connection.Close();
            return expandedOrderDetailViews;
        }

        public List<ExpandedOrderDetailView> getSearchByWorkerPIB(ExpandedOrderDetailView expandedOrderDetailView)
        {
            List<ExpandedOrderDetailView> expandedOrderDetailViews = new List<ExpandedOrderDetailView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from expanded_order_detail where worker_pib = @worker_pib;";
            command.Parameters.AddWithValue("@worker_pib", expandedOrderDetailView.worker_pib);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedOrderDetailView eod = new ExpandedOrderDetailView
                    {
                        order_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        order_date = reader.GetDateTime(3),
                        detail_name = reader.GetString(4),
                        quantity = reader.GetInt32(5),
                        total_price = reader.GetDecimal(6)
                    };
                    expandedOrderDetailViews.Add(eod);
                }
            }
            connection.Close();
            return expandedOrderDetailViews;
        }

        public List<ExpandedOrderDetailView> getSearchByClientPIB(ExpandedOrderDetailView expandedOrderDetailView)
        {
            List<ExpandedOrderDetailView> expandedOrderDetailViews = new List<ExpandedOrderDetailView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from expanded_order_detail where client_pib = @client_pib;";
            command.Parameters.AddWithValue("@client_pib", expandedOrderDetailView.client_pib);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExpandedOrderDetailView eod = new ExpandedOrderDetailView
                    {
                        order_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        client_pib = reader.GetString(2),
                        order_date = reader.GetDateTime(3),
                        detail_name = reader.GetString(4),
                        quantity = reader.GetInt32(5),
                        total_price = reader.GetDecimal(6)
                    };
                    expandedOrderDetailViews.Add(eod);
                }
            }
            connection.Close();
            return expandedOrderDetailViews;
        }
    }
}
