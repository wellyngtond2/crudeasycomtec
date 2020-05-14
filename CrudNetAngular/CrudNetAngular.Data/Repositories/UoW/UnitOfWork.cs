using CrudNetAngular.Core.Repositories;
using CrudNetAngular.Core.Repositories.UoW;
using CrudNetAngular.Data.Context;

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
            _DataContext = dataContext;
        }

        /// <summary>
        /// Flag to identify if Dispose has already been called.
        /// </summary>
        private bool _disposed;
        /// <summary>
        /// Instance of dbcontext
        /// </summary>
        private DataContext _DataContext { get; }

        public IDeveloperRepository DeveloperRepository => _developerRepository ?? (_developerRepository = new DeveloperRepository(_DataContext));
        public ITalentBaseRepository TalentBaseRepository => _talentBaseRepository ?? (_talentBaseRepository = new TalentBaseRepository(_DataContext));


        public void BeginTransaction()
        {
            _DataContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _DataContext.SaveChanges();
            _DataContext.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _DataContext.Database.RollbackTransaction();
        }


        public void Dispose()
        {
            _DataContext.Dispose();
        }
    }
}
