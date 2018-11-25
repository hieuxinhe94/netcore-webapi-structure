using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class ProductModel : BaseEntity
    {
        public ProductModel()
        {
            Products = new HashSet<Product>();
        }

        public string ModelName { get; set; }
        public int? ParentId { get; set; }
        public DateTime? DateCreate { get; set; }

        public ProductCategory Parent { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
