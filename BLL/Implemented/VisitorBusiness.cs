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
    public class VisitorBusiness : IVisitorBusiness
    {
        private readonly IVisitorRepositoy _visitorRepositoy;

        public VisitorBusiness(IVisitorRepositoy visitorRepositoy)
        {
            _visitorRepositoy = visitorRepositoy;
        }
        public async Task<ServiceResponeCode> CreateAsync(Visitor entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _visitorRepositoy.CreateAsync(entityToCreate);
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
                await _visitorRepositoy.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<Visitor> GetAllWithoutPagination()
        {
            return _visitorRepositoy.GetAll().ToList();
        }

        public ICollection<Visitor> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _visitorRepositoy.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Visitor> GetByIdAsync(int id)
        {
            return await _visitorRepositoy.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, Visitor entityToUpdate)
        {
            var current = _visitorRepositoy.GetByIdAsync(id);

            if (current != null)
            {
                await _visitorRepositoy.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
