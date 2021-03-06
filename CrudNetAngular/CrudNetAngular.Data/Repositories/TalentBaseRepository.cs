﻿using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Data.Context;

namespace CrudNetAngular.Data.Repositories
{
    public sealed class TalentBaseRepository : BaseRepository<TalentBase>, ITalentBaseRepository
    {
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _dataContext { get; }
        public TalentBaseRepository(DataContext dbContext) : base(dbContext)
        {
            _dataContext = dbContext;
        }
    }
}
