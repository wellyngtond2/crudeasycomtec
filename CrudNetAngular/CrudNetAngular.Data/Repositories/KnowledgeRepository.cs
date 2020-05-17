using CrudNetAngular.Core.Models;
using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Data.Context;

namespace CrudNetAngular.Data.Repositories
{
    public sealed class KnowledgeRepository : BaseRepository<Knowledge>, IKnowledgeRepository
    {
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _dataContext { get; }
        public KnowledgeRepository(DataContext dbContext) : base(dbContext)
        {
            _dataContext = dbContext;
        }
    }
}
