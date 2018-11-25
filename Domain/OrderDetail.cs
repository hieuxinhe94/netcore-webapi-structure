using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string DetailDescription { get; set; }
        public double? DetailPrice { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
