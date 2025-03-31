using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Kyrsova1PolynkoP_20
{
    internal class worker_tovarInfoDAO
    {
        public List<worker_tovarInfo> wtInfo = new List<worker_tovarInfo>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";
        internal List<worker_tovarInfo> worker_tovarInfo()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT LCASE(worker.worker_pib) AS 'worker_pib', UCASE(tovar.type_of_tovar) AS 'tovar_name', (CHAR_LENGTH(worker.worker_pib)-2) AS 'Довжина ПІБ робітника' FROM worker " +
                "INNER JOIN zamov ON zamov.worker_id = worker.worker_id INNER JOIN tovar ON tovar.tovar_id = zamov.tovar_id WHERE tovar.type_of_tovar = (SELECT type_of_tovar FROM tovar " +
                "WHERE tovar.tovar_id = zamov.tovar_id);", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    worker_tovarInfo wti = new worker_tovarInfo
                    {
                        worker_pib = reader.IsDBNull(0) ? null : reader.GetString(0),
                        type_of_tovar = reader.IsDBNull(1) ? null : reader.GetString(1),
                        char_length_worker_pib = reader.IsDBNull(2) ? null : reader.GetInt32(2)
                    };
                    wtInfo.Add(wti);
                }
            }
            connection.Close();
            return wtInfo;
        }
    }

}
