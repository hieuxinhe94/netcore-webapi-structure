
using Core;
using Core.ViewModel;
using Domains;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bll.Interfaces
{
    public interface ICustomerBusiness
    {
        #region CRUD Basic

        /// <summary>
        ///  Return a list contains all of record from db
        /// </summary>
        /// <returns></returns>
        ICollection<Customer> GetAllWithoutPagination();

        /// <summary>
        ///  Return a list with pagination
        /// </summary>
        /// <param name="searchView"></param>
        /// <returns></returns>
        ICollection<Customer> GetAllWithPagination(SearchViewModel searchView);

        /// <summary>
        ///  Find a entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Customer> GetByIdAsync(int id);

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
        Task<ServiceResponeCode> UpdateAsync(int id, Customer entityToUpdate);

        /// <summary>
        ///  Create entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityToUpdate"></param>
        /// <returns>ServiceResponeCode</returns>
        Task<ServiceResponeCode> CreateAsync(Customer entityToCreate);

        #endregion
    }
}
