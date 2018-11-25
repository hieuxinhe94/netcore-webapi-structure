using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class ProductModelRepository : RepositoryBase<ProductModel>, IProductModelRepository
    {
        public ProductModelRepository(ApplicationContext context) : base(context)
        {

        }
 
    }
}
