using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.Implemented
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<ICollection<Product>> GetRecommendProduct(int id, int count, int optionId)
        {
            // ToDO: Implement your logic to get them
            var thisProduct = await GetByIdAsync(id);

            return await GetAll().OrderBy(t => t.Id).Where(t => t.ProductCategoryId > thisProduct.ProductCategoryId).Take(count).ToListAsync();
        }
    }
}
