using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    internal class Sklad
    {
        public int place_id { get; set; }
        public int? sklad_id { get; set; }
        public int? tovar_id { get; set; }
        public String type_of_tovar { get; set; }
        public String nayavnist { get; set; }
        public int? kilkist_tovar { get; set; }
    }
}
