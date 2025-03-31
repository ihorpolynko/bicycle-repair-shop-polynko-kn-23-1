using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Kyrsova1PolynkoP_20
{
    class profitDAO
    {
        public List<Profit> masters = new List<Profit>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Profit> getALLProfits()
        {
            List<Profit> profits = new List<Profit>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from profit;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Profit p = new Profit
                    {
                        period = reader.GetInt32(0),
                        profit_kilkist = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                        vutraru = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                    };
                    profits.Add(p);
                }
            }
            connection.Close();
            return profits;
        }

        internal int addProfit(int period, int profit_kilkist, int vutraru)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into profit (period, profit_kilkist, vutraru) values(@period, @profit_kilkist, @vutraru);";
            command.Parameters.AddWithValue("@period", period);
            command.Parameters.AddWithValue("@profit_kilkist", profit_kilkist == 0 ? (object)DBNull.Value : profit_kilkist);
            command.Parameters.AddWithValue("@vutraru", vutraru == 0 ? (object)DBNull.Value : vutraru);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteProfit(int profit)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from profit WHERE (period = @period);";
            command.Parameters.AddWithValue("@period", profit);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateProfit(Profit profit)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update profit set period = @period, profit_kilkist = @profit_kilkist, vutraru = @vutraru WHERE (period = @period) and period between 1 and 12;";
            command.Parameters.AddWithValue("@period", profit.period);
            command.Parameters.AddWithValue("@profit_kilkist", profit.profit_kilkist);
            command.Parameters.AddWithValue("@vutraru", profit.vutraru);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
