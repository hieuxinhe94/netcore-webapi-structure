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
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<ServiceResponeCode> CreateAsync(Employee entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _employeeRepository.CreateAsync(entityToCreate);
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
                await _employeeRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<Employee> GetAllWithoutPagination()
        {
            return _employeeRepository.GetAll().ToList();
        }

        public ICollection<Employee> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _employeeRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, Employee entityToUpdate)
        {
            var current = _employeeRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _employeeRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
