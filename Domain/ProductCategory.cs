using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class ProductCategory : BaseEntity
    {
        public ProductCategory()
        {
            InverseParent = new HashSet<ProductCategory>();
            ProductModels = new HashSet<ProductModel>();
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public DateTime? DateCreate { get; set; }

        public ProductCategory Parent { get; set; }
        public ICollection<ProductCategory> InverseParent { get; set; }
        public ICollection<ProductModel> ProductModels { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
