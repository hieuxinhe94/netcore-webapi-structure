using Bll.Interfaces;
using Core;
using Core.ViewModel;
using Dal.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bll.Implemented
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepositoy _userRepository;

        public UserBusiness(IUserRepositoy userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(User entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _userRepository.CreateAsync(entityToCreate);
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
                await _userRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<User> GetAllWithoutPagination()
        {
            return _userRepository.GetAll().ToList();
        }

        public ICollection<User> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _userRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, User entityToUpdate)
        {
            var current = _userRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _userRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
