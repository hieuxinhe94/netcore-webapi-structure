using Bll.Interfaces;
using Core;
using Core.ViewModel;
using Dal.Interfaces;
using Domains;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Implemented
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task<ServiceResponeCode> Delete(int id)
        {
            var currentEntiry = this._productRepository.GetByIdAsync(id);

            if (currentEntiry != null)
            {
                await _productRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }

        public ICollection<Product> GetAllWithoutPagination()
        {
            return _productRepository.GetAll().ToList();
        }

        public ICollection<Product> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _productRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public Product GetById(int id)
        {
            return _productRepository.GetByIdAsync(id).Result;
        }

        public ICollection<Product> GetRecommend(int id)
        {
            return _productRepository.GetRecommendProduct(id, 3, 0).Result;
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, Product entityToUpdate)
        {
            var current = _productRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _productRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;

            }
            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
