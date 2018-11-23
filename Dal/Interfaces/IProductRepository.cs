using Dal.Interfaces.Base;
using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        // More specific methods only need on Product Data Access Layer
        Task<ICollection<Product>> GetRecommendProduct(int id, int count, int optionId);
    }
}
