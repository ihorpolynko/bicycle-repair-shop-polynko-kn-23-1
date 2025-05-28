using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public class Orders
    {
        public int order_id { get; set; }
        public int client_id { get; set; }
        public int worker_id { get; set; }
        public DateTime order_date { get; set; }
        public Decimal? payment_amount { get; set; }
        public DateTime? payment_date { get; set; }
    }
}