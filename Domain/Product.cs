
using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class Product : BaseEntity
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public double? ProductDiscount { get; set; }
        public double? ProductCostReference { get; set; }
        public string ProductReference { get; set; }
        public double? ProductWeight { get; set; }
        public string ProductTags { get; set; }
        public string ProductShortDesc { get; set; }
        public string ProductLongDesc { get; set; }
        public string ProductThumb { get; set; }
        public string ProductAvatar { get; set; }
        public int? ProductCategoryId { get; set; }
        public DateTime? ProductUpdateDate { get; set; }
        public int? ProductCount { get; set; }
        public int? ProductModelId { get; set; }
        public string ProductLocation { get; set; }
        public int? ProductIssurance { get; set; }
        public string ProductIssuranceDesc { get; set; }
        public bool? ProductIsAvailable { get; set; }
        public bool? ProductIsDeleted { get; set; }
        public bool? ProductDateCreated { get; set; }
        public int? ProductViewTypeId { get; set; }
        public double? Rating { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public ProductModel ProductModel { get; set; }
        public ProductView ProductViewType { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
