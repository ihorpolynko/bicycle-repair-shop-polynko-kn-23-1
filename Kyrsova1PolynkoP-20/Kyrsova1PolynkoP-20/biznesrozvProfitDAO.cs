using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Windows.Forms;

namespace Kyrsova1PolynkoP_20
{
    internal class biznesrozvProfitDAO
    {
        public List<BiznesrozvProfit> brProfit = new List<BiznesrozvProfit>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";
        internal List<BiznesrozvProfit> biznesrozvProfit()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT period, (`Чистий прибуток за кожний місяць` - " +
            "FLOOR(`Чистий прибуток за кожний місяць` / 1.5)) AS 'Витрати на розвиток бізнесу з чистого прибутку за останній місяць' " +
            "FROM profit_view ORDER BY period DESC LIMIT 1; ", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    BiznesrozvProfit brp = new BiznesrozvProfit
                    {
                        month_num = reader.GetInt32(0),
                        vutratuOnRozvBiznes = reader.IsDBNull(1) ? null : reader.GetInt32(1)
                    };
                    brProfit.Add(brp);
                }
            }
            connection.Close();
            return brProfit;
        }
    }
}
