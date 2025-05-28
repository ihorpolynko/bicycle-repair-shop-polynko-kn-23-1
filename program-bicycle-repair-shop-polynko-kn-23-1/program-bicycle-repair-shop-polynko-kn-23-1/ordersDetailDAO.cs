using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    internal class ordersDetailDAO
    {
        public List<OrdersDetail> ordersdetail = new List<OrdersDetail>();

        public List<OrdersDetail> getALLOrdersDetail()
        {
            List<OrdersDetail> ordersdetail = new List<OrdersDetail>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from order_detail;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    OrdersDetail od = new OrdersDetail
                    {
                        order_id = reader.GetInt32(0),
                        detail_id = reader.GetInt32(1),
                        quantity_details = reader.GetInt32(2)
                    };
                    ordersdetail.Add(od);
                }
            }
            connection.Close();
            return ordersdetail;
        }

        internal int addOrdersDetail(OrdersDetail ordersdetail)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into order_detail (order_id, detail_id, quantity_details) values(@order_id, @detail_id, @quantity_details);";
            command.Parameters.AddWithValue("@order_id", ordersdetail.order_id);
            command.Parameters.AddWithValue("@detail_id", ordersdetail.detail_id);
            command.Parameters.AddWithValue("@quantity_details", ordersdetail.quantity_details);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteOrdersDetail(OrdersDetail ordersdetail)
        {
            using (MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig()))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    MySqlCommand deleteCmd = new MySqlCommand(@"
                DELETE FROM order_detail 
                WHERE order_id = @order_id AND detail_id = @detail_id;", connection, transaction);
                    deleteCmd.Parameters.AddWithValue("@order_id", ordersdetail.order_id);
                    deleteCmd.Parameters.AddWithValue("@detail_id", ordersdetail.detail_id);
                    int result = deleteCmd.ExecuteNonQuery();

                    // Обновляем сумму, если 0 — ставим NULL
                    MySqlCommand updateCmd = new MySqlCommand(@"
                UPDATE `order` o
                SET o.payment_amount = (
                    SELECT CASE 
                        WHEN SUM(d.price * od.quantity_details) = 0 THEN NULL
                        ELSE SUM(d.price * od.quantity_details)
                    END
                    FROM order_detail od
                    JOIN details d ON od.detail_id = d.detail_id
                    WHERE od.order_id = @order_id
                )
                WHERE o.order_id = @order_id;", connection, transaction);
                    updateCmd.Parameters.AddWithValue("@order_id", ordersdetail.order_id);
                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return result;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return 0;
                }
            }
        }

        internal int updateOrdersDetail(OrdersDetail ordersdetail)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update order_detail set quantity_details = @quantity_details where order_id = @order_id and detail_id = @detail_id;";
            command.Parameters.AddWithValue("@order_id", ordersdetail.order_id);
            command.Parameters.AddWithValue("@detail_id", ordersdetail.detail_id);
            command.Parameters.AddWithValue("@quantity_details", ordersdetail.quantity_details);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
