using Bll.Interfaces;
using Core;
using Core.ViewModel;
using Dal.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Implemented
{
    public class AppParamBusiness : IAppParamBusiness
    {
        private readonly IAppRepository _appRepository;

        public AppParamBusiness(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(ApplicationParam entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _appRepository.CreateAsync(entityToCreate);
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
                await _appRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<ApplicationParam> GetAllWithoutPagination()
        {
            return _appRepository.GetAll().ToList();
        }

        public ICollection<ApplicationParam> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _appRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<ApplicationParam> GetByIdAsync(int id)
        {
            return await _appRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, ApplicationParam entityToUpdate)
        {
            var current = _appRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _appRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
