using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Collections.Generic;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    class reportsDAO
    {
        public List<MonthlyWorkerProfit> getALLmonthlyWorkerProfit()
        {
            List<MonthlyWorkerProfit> monthlyWorkerProfit = new List<MonthlyWorkerProfit>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from monthly_worker_profit;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    MonthlyWorkerProfit mwp = new MonthlyWorkerProfit
                    {
                        worker_id = reader.GetInt32(0),
                        worker_pib = reader.GetString(1),
                        position = reader.GetString(2),
                        profit = reader.GetDecimal(3)
                    };
                    monthlyWorkerProfit.Add(mwp);
                }
            }
            connection.Close();
            return monthlyWorkerProfit;
        }

        public List<MonthlyDetailsSales> getALLmonthlyDetailsSales()
        {
            List<MonthlyDetailsSales> monthlyDetailsSales = new List<MonthlyDetailsSales>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from monthly_details_sales;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    MonthlyDetailsSales mds = new MonthlyDetailsSales
                    {
                        detail_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                        total_sold = reader.GetInt32(3)
                    };
                    monthlyDetailsSales.Add(mds);
                }
            }
            connection.Close();
            return monthlyDetailsSales;
        }
    }
}