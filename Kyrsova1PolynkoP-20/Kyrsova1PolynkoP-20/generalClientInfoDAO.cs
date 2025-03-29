using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class generalClientInfoDAO
    {
        public List<generalClientInfo> genClientInfo = new List<generalClientInfo>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";
        internal object getMOREClients()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT CONCAT(SUBSTRING_INDEX(UCASE(client.client_pib), ' ', 1), '-', client.type_of_zamov) AS 'Короткі відомості клієнта', " +
                "tovar.type_of_tovar AS 'Назва товару', zapus_na_remont.reason_of_remont AS 'Причина ремонту' FROM client LEFT JOIN zamov ON zamov.client_id = client.client_id " +
                "LEFT JOIN tovar ON zamov.tovar_id = tovar.tovar_id LEFT JOIN zapus_na_remont ON zapus_na_remont.client_id = client.client_id;";
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    generalClientInfo gci = new generalClientInfo
                    {
                        shortClientInfo = reader.IsDBNull(0) ? null : reader.GetString(0),
                        tovarName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        remontReason = reader.IsDBNull(2) ? null : reader.GetString(2)
                    };
                    genClientInfo.Add(gci);
                }
            }
            connection.Close();
            return genClientInfo;
        }
    }
}
