using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class ProductView : BaseEntity
    {
        public ProductView()
        {
            Products = new HashSet<Product>();
        }

        public string ProductViewName { get; set; }
        public DateTime? DateCreate { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
