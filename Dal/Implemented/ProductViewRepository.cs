using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class ProductViewRepository : RepositoryBase<ProductView>, IProductViewRepository
    {
        public ProductViewRepository(ApplicationContext context) : base(context)
        {

        }
 
    }
}
