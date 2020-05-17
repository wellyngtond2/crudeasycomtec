using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Data.Context;

namespace CrudNetAngular.Data.Repositories
{
    public sealed class OccupationRepository : BaseRepository<Occupation>, IOccupationRepository
    {
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _dataContext { get; }
        public OccupationRepository(DataContext dbContext) : base(dbContext)
        {
            _dataContext = dbContext;
        }
    }
}
