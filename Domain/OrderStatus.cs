using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class OrderStatus : BaseEntity
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public string Descriotions { get; set; }
        public DateTime? DateCreate { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
