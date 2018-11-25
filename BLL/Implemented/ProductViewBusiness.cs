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
    public class ProductViewBusiness : IProductViewBusiness
    {
        private readonly IProductViewRepository _productViewRepository;

        public ProductViewBusiness(IProductViewRepository productViewRepository)
        {
            _productViewRepository = productViewRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(ProductView entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _productViewRepository.CreateAsync(entityToCreate);
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
                await _productViewRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<ProductView> GetAllWithoutPagination()
        {
            return _productViewRepository.GetAll().ToList();
        }

        public ICollection<ProductView> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _productViewRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<ProductView> GetByIdAsync(int id)
        {
            return await _productViewRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, ProductView entityToUpdate)
        {
            var current = _productViewRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _productViewRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
