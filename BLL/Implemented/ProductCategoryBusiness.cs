using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll.Interfaces;
using Core;
using Core.ViewModel;
using Dal.Interfaces;
using Domains;

namespace Bll.Implemented
{
    public class ProductCategoryBusiness : IProductCategoryBusiness
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryBusiness(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(ProductCategory entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _productCategoryRepository.CreateAsync(entityToCreate);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public async Task<ServiceResponeCode> DeleteAsync(int id)
        {
            if (id == 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _productCategoryRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<ProductCategory> GetAllWithoutPagination()
        {
            return _productCategoryRepository.GetAll().ToList();
        }

        public ICollection<ProductCategory> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _productCategoryRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<ProductCategory> GetByIdAsync(int id)
        {
            return await _productCategoryRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, ProductCategory entityToUpdate)
        {
            var current = _productCategoryRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _productCategoryRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
