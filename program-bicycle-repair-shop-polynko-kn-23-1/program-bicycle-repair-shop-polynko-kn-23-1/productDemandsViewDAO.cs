using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    internal class productDemandsViewDAO
    {
        public List<ProductDemandView> productDemandsView = new List<ProductDemandView>();

        public List<ProductDemandView> getALLproductDemandsView()
        {
            List<ProductDemandView> productDemandsView = new List<ProductDemandView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from product_demand;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProductDemandView pd = new ProductDemandView
                    {
                        detail_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                        total_sold = reader.GetDecimal(3)
                    };
                    productDemandsView.Add(pd);
                }
            }
            connection.Close();
            return productDemandsView;
        }

        public List<ProductDemandView> getSearchByID(ProductDemandView productDemandView)
        {
            List<ProductDemandView> productDemandsView = new List<ProductDemandView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from product_demand where detail_id = @detail_id;";
            command.Parameters.AddWithValue("@detail_id", productDemandView.detail_id);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProductDemandView pd = new ProductDemandView
                    {
                        detail_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                        total_sold = reader.GetDecimal(3)
                    };
                    productDemandsView.Add(pd);
                }
            }
            connection.Close();
            return productDemandsView;
        }

        public List<ProductDemandView> getSearchByName(ProductDemandView productDemandView)
        {
            List<ProductDemandView> productDemandsView = new List<ProductDemandView>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from product_demand where name = @name;";
            command.Parameters.AddWithValue("@name", productDemandView.name);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ProductDemandView pd = new ProductDemandView
                    {
                        detail_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                        total_sold = reader.GetDecimal(3)
                    };
                    productDemandsView.Add(pd);
                }
            }
            connection.Close();
            return productDemandsView;
        }
    }
}