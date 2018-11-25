using Bll.Interfaces;
using Core;
using Core.ViewModel;
using Dal.Interfaces;
using Domains;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bll.Implemented
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerBusiness(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(Customer entityToUpdate)
        {
            if (entityToUpdate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _customerRepository.CreateAsync(entityToUpdate);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public async Task<ServiceResponeCode> Delete(int id)
        {
            if (id == 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _customerRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<Customer> GetAllWithoutPagination()
        {
            return _customerRepository.GetAll().ToList();
        }

        public ICollection<Customer> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _customerRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, Customer entityToUpdate)
        {
            var current = _customerRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _customerRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;

            }
            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
