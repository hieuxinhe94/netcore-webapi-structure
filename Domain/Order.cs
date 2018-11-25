using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class Order : BaseEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
 
        public int CustomerId { get; set; }
        public int ProductCount { get; set; }
        public string ShipAddress { get; set; }
        public string ShipContactPhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OrderUpdatedDate { get; set; }
        public int OrderStatusId { get; set; }
        public int? ShipperId { get; set; }
        public bool? OrderDeleted { get; set; }

        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Employee Shipper { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
