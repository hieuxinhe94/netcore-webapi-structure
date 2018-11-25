using Core;
using Core.ViewModel;
using Domains;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bll.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        ///  Return a list contains all of record from db
        /// </summary>
        /// <returns></returns>
        ICollection<Product> GetAllWithoutPagination();

        /// <summary>
        ///  Return a list with pagination
        /// </summary>
        /// <param name="searchView"></param>
        /// <returns></returns>
        ICollection<Product> GetAllWithPagination(SearchViewModel searchView);

        /// <summary>
        ///  Find a entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetById(int id);

        /// <summary>
        ///  Get a range of neigbor entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ICollection<Product> GetRecommend(int id);

        /// <summary>
        /// Delete item from db
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ServiceResponeCode</returns>
        Task<ServiceResponeCode> Delete(int id);

        /// <summary>
        ///  Update entity with id provided to new entity, not chage the id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityToUpdate"></param>
        /// <returns>ServiceResponeCode</returns>
        Task<ServiceResponeCode> UpdateAsync(int id, Product entityToUpdate);
    }
}
