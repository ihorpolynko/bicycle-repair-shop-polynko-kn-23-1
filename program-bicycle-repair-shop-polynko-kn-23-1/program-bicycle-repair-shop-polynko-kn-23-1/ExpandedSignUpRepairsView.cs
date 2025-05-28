using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    internal class ExpandedSignUpRepairsView
    {
        public int sign_up_repairs_id { get; set; }
        public String worker_pib { get; set; }
        public String client_pib { get; set; }
        public DateTime sign_up_date { get; set; }
        public Decimal payment_amount { get; set; }
    }
}
