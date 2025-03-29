using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsova1PolynkoP_20
{
    class detailInfoZamovClientDAO
    {
        public List<DetailInfoZamovClient> detInZamovClient = new List<DetailInfoZamovClient>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";
        internal object getdetailInfoZamovClient()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT zamov.zamov_id, client.client_pib, worker.worker_pib, tovar.type_of_tovar, kilkist_tovar, DAY(date_of_zamov) AS day_of_zamov FROM zamov " +
                "LEFT JOIN client ON zamov.client_id = client.client_id LEFT JOIN worker ON zamov.worker_id = worker.worker_id LEFT JOIN tovar ON zamov.tovar_id = tovar.tovar_id;";
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    DetailInfoZamovClient dizc = new DetailInfoZamovClient
                    {
                        zamov_id = reader.GetInt32(0),
                        client_pib = reader.IsDBNull(1) ? null : reader.GetString(1),
                        worker_pib = reader.IsDBNull(2) ? null : reader.GetString(2),
                        type_of_tovar = reader.IsDBNull(3) ? null : reader.GetString(3),
                        kilkist_tovar = reader.IsDBNull(4) ? null : reader.GetInt32(4),
                        day_of_zamov = reader.IsDBNull(5) ? null : reader.GetInt32(5)
                    };
                    detInZamovClient.Add(dizc);
                }
            }
            connection.Close();
            return detInZamovClient;
        }
    }
}
