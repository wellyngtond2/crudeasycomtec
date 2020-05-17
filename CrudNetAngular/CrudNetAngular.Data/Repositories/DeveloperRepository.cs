using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Data.Context;

namespace CrudNetAngular.Data.Repositories
{
    public sealed class DeveloperRepository : BaseRepository<Developer>, IDeveloperRepository
    {
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _dataContext { get; }
        public DeveloperRepository(DataContext dbContext) : base(dbContext)
        {
            _dataContext = dbContext;
        }
    }
}
