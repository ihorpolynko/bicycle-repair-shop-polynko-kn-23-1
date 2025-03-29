using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;

namespace Kyrsova1PolynkoP_20
{
    internal class profit_viewDAO
    {
        public List<Profit_view> profits_view = new List<Profit_view>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";

        public List<Profit_view> getProfits_view()
        {
            List<Profit_view> profits_view = new List<Profit_view>();
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from profit_view;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Profit_view p_v = new Profit_view
                    {
                        period = reader.GetInt32(0),
                        clear_profit = reader.IsDBNull(1) ? null : reader.GetDouble(1)
                    };
                    profits_view.Add(p_v);
                }
            }
            connection.Close();
            return profits_view;
        }
        internal int biznesrozvProfit(Profit_view profit_view)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT period, (`Чистий прибуток за кожний місяць` - FLOOR(`Чистий прибуток за кожний місяць` / 1.5))" +
                "AS 'Витрати на розвиток бізнесу з чистого прибутку за останній місяць' FROM profit_view ORDER BY period DESC LIMIT 1;";
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}