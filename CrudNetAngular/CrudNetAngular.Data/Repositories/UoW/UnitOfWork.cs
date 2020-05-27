using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Data.Context;
using System.Threading.Tasks;

namespace CrudNetAngular.Data.Repositories.UoW
{
    /// <summary>
    /// Unit of work of repositories.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private IDeveloperRepository _developerRepository;
        private ITalentBaseRepository _talentBaseRepository;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _dataContext { get; }

        public IDeveloperRepository DeveloperRepository => _developerRepository ?? (_developerRepository = new DeveloperRepository(_dataContext));
        public ITalentBaseRepository TalentBaseRepository => _talentBaseRepository ?? (_talentBaseRepository = new TalentBaseRepository(_dataContext));


        public async Task BeginTransactionAsync()
        {
            await _dataContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            await _dataContext.SaveChangesAsync();
            _dataContext.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _dataContext.Database.RollbackTransaction();
        }


        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
