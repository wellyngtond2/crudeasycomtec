using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudNetAngular.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        private DataContext _dataContext;
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Add(TEntity entity)
        {
            await _dataContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await Task.FromResult(_dataContext.Set<TEntity>().Remove(entity));

        }

        public async Task<IEnumerable<TEntity>> GetByAll()
        {
            return await _dataContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _dataContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity)
        {
            await Task.FromResult(_dataContext.Entry(entity).State = EntityState.Modified);
        }
    }
}
