using Core;
using Core.ViewModel;
using Domains;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Bll.Interfaces
{
    public interface IOrderStatusBusiness
    {
        #region CRUD Basic

        /// <summary>
        ///  Return a list contains all of record from db
        /// </summary>
        /// <returns></returns>
        ICollection<OrderStatus> GetAllWithoutPagination();

        /// <summary>
        ///  Return a list with pagination
        /// </summary>
        /// <param name="searchView"></param>
        /// <returns></returns>
        ICollection<OrderStatus> GetAllWithPagination(SearchViewModel searchView);

        /// <summary>
        ///  Find a entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrderStatus GetById(int id);

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
        Task<ServiceResponeCode> UpdateAsync(int id, OrderStatus entityToUpdate);

        /// <summary>
        ///  Create entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityToUpdate"></param>
        /// <returns>ServiceResponeCode</returns>
        Task<ServiceResponeCode> CreateAsync(OrderStatus entityToCreate);

        #endregion
    }
}
