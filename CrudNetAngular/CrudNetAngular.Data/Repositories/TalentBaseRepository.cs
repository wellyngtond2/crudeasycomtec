using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Repositories;
using CrudNetAngular.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrudNetAngular.Data.Repositories
{
    public sealed class TalentBaseRepository : ITalentBaseRepository
    {
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _DataContext { get; }
        public TalentBaseRepository(DataContext dbContext)
        {
            _DataContext = dbContext;
        }
        public Task Add(TalentBase entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TalentBase entity)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TalentBase>> GetByAll()
        {
            throw new NotImplementedException();
        }

        public Task<TalentBase> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(TalentBase entity)
        {
            throw new NotImplementedException();
        }
    }
}
