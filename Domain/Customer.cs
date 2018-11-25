using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class Customer : BaseEntity
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string IpAddress { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? VisistedDate { get; set; }
        public string Url { get; set; }
        public string ProductViewedIds { get; set; }
        public DateTime? LastVisistedDate { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
