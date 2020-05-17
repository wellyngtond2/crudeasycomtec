using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Data.Context;

namespace CrudNetAngular.Data.Repositories
{
    public sealed class TalentBaseXOccupationRepository : BaseRepository<TalentBaseXOccupation>, ITalentBaseXOccupationRepository
    {
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _dataContext { get; }
        public TalentBaseXOccupationRepository(DataContext dbContext) : base(dbContext)
        {
            _dataContext = dbContext;
        }
    }
}
