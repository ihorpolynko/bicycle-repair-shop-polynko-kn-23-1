using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class DetailInfoZamovClient
    {
        public int zamov_id { get; set; }
        public String client_pib { get; set; }
        public String worker_pib { get; set; }
        public String type_of_tovar { get; set; }
        public int? kilkist_tovar { get; set; }
        public int? day_of_zamov { get; set; }
    }
}