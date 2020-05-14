using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Repositories;
using CrudNetAngular.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudNetAngular.Data.Repositories
{
    public sealed class DeveloperRepository : IDeveloperRepository
    {
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _DataContext { get; }
        public DeveloperRepository(DataContext dbContext)
        {
            _DataContext = dbContext;
        }

        public async Task Add(Developer entity)
        {
            await _DataContext.Developer.AddAsync(entity);
        }

        public async Task Delete(Developer entity)
        {
            await Task.FromResult(_DataContext.Developer.Remove(entity));
        }

        public async Task<ICollection<Developer>> GetByAll()
        {
            return await _DataContext.Developer.ToListAsync();
        }

        public async Task<Developer> GetById(Guid id)
        {
            return await _DataContext.Developer.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task Update(Developer entity)
        {
            await Task.FromResult(_DataContext.Entry(entity).State = EntityState.Modified);
        }
    }
}
