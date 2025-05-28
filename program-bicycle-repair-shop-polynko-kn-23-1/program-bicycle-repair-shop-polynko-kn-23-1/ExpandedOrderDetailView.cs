using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public class ExpandedOrderDetailView
    {
        public int order_id { get; set; }
        public String worker_pib { get; set; }
        public String client_pib { get; set; }
        public DateTime order_date { get; set; }
        public String detail_name { get; set; }
        public int quantity { get; set; }
        public decimal total_price { get; set; }
    }
}