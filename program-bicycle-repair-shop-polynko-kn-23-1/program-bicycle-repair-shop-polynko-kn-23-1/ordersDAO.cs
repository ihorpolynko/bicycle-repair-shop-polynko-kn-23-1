using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public class ordersDAO
    {
        public List<Orders> orders = new List<Orders>();

        public List<Orders> getALLOrders()
        {
            List<Orders> orders = new List<Orders>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from `order`;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Orders o = new Orders
                    {
                        order_id = reader.GetInt32(0),
                        client_id = reader.GetInt32(1),
                        worker_id = reader.GetInt32(2),
                        order_date = reader.GetDateTime(3),
                        payment_amount = reader.IsDBNull(4) ? (decimal?)null : reader.GetDecimal(4),
                        payment_date = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                    };
                    orders.Add(o);
                }
            }
            connection.Close();
            return orders;
        }

        internal int addOrder(Orders order)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into `order` (client_id, worker_id, order_date) values(@client_id, @worker_id, @order_date);";
            command.Parameters.AddWithValue("@client_id", order.client_id);
            command.Parameters.AddWithValue("@worker_id", order.worker_id);
            command.Parameters.AddWithValue("@order_date", order.order_date);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteOrder(Orders order)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from `order` where (order_id = @order_id);";
            command.Parameters.AddWithValue("@order_id", order.order_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateOrder(Orders order)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update `order` set client_id = @client_id, worker_id = @worker_id, payment_date = @payment_date WHERE (order_id = @order_id);";
            command.Parameters.AddWithValue("@order_id", order.order_id);
            command.Parameters.AddWithValue("@client_id", order.client_id);
            command.Parameters.AddWithValue("@worker_id", order.worker_id);
            command.Parameters.AddWithValue("@payment_date", order.payment_date);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Orders> getSearchOrders(Orders order)
        {
            List<Orders> orders = new List<Orders>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from `order` where client_id = @client_id;";
            command.Parameters.AddWithValue("@client_id", order.client_id);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Orders o = new Orders
                    {
                        order_id = reader.GetInt32(0),
                        client_id = reader.GetInt32(1),
                        worker_id = reader.GetInt32(2),
                        order_date = reader.GetDateTime(3),
                        payment_amount = reader.IsDBNull(4) ? (decimal?)null : reader.GetDecimal(4),
                        payment_date = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                    };
                    orders.Add(o);
                }
            }
            connection.Close();
            return orders;
        }

        public int getLastOrderId()
        {
            int lastId = -1;

            using (MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig()))
            {
                connection.Open();

                string query = "SELECT MAX(order_id) FROM `order`";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lastId = Convert.ToInt32(result);
                    }
                }
            }

            return lastId;
        }
    }
}