using CrudNetAngular.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Interfaces.Repositories
{
    /// <summary>
    /// Base of repositories
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : BaseModel
    {
        /// <summary>
        /// Add new entity.
        /// </summary>
        /// <param name="entity"></param>
        Task Add(TEntity entity);
        /// <summary>
        /// Update entity.
        /// </summary>
        /// <param name="entity"></param>
        Task Update(TEntity entity);
        /// <summary>
        /// Delete entity.
        /// </summary>
        /// <param name="entity"></param>
        Task Delete(TEntity entity);
        /// <summary>
        /// Retrieve  an entity.
        /// </summary>
        /// <param name="id"></param>
        Task<TEntity> GetById(Guid id);
        /// <summary>
        /// Retrieve  a list of  all entity.
        /// </summary>
        Task<IEnumerable<TEntity>> GetByAll();
    }
}
