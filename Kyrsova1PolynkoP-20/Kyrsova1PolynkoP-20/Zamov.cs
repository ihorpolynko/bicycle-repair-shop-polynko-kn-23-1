using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class Zamov
    {
        public int zamov_id { get; set; }
        public int? client_id { get; set; }
        public int? worker_id { get; set; }
        public int? tovar_id { get; set; }
        public int? kilkist_tovar { get; set; }
        public DateTime? date_of_zamov { get; set; }
    }
}
