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
    public class ProductModelBusiness : IProductModelBusiness
    {
        private readonly IProductModelRepository _productModelRepository;

        public ProductModelBusiness(IProductModelRepository productModelRepository)
        {
            _productModelRepository = productModelRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(ProductModel entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _productModelRepository.CreateAsync(entityToCreate);
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
                await _productModelRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<ProductModel> GetAllWithoutPagination()
        {
            return _productModelRepository.GetAll().ToList();
        }

        public ICollection<ProductModel> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _productModelRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<ProductModel> GetByIdAsync(int id)
        {
            return await _productModelRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, ProductModel entityToUpdate)
        {
            var current = _productModelRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _productModelRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
