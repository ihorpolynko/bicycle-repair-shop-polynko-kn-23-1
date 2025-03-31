using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova1PolynkoP_20
{
    class Zapus_na_remont
    {
        public int zapus_na_remont_id { get; set; }
        public int? client_id { get; set; }
        public int? master_id { get; set; }
        public String reason_of_remont { get; set; }
        public DateTime? remont_date { get; set; }
        public double? oplata { get; set; }
    }
}
