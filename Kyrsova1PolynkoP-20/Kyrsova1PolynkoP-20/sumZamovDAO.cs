using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsova1PolynkoP_20
{
    internal class sumZamovDAO
    {
        public List<SumZamov> sumZam = new List<SumZamov>();
        string connectionstring = "datasource=127.0.0.1;username=root;password=4865922Mnip;database=lr5poylnko";
        internal object getSumZamov()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT SUM(tovar.prise_of_tovar * zamov.kilkist_tovar) AS 'Сума усіх замовлень' FROM zamov INNER JOIN tovar ON tovar.tovar_id = zamov.tovar_id;";
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SumZamov sz = new SumZamov
                    {
                        prise_of_tovar = reader.IsDBNull(0) ? null : reader.GetDouble(0),
                    };
                    sumZam.Add(sz);
                }
            }
            connection.Close();
            return sumZam;
        }
    }
}
