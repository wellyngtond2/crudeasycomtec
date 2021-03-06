﻿using CrudNetAngular.Core.Models;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Interfaces.Repositories.UoW
{
    /// <summary>
    /// Unit of work of repositories.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Repository to handle information about <see cref="Developer"/>
        /// </summary>
        IDeveloperRepository DeveloperRepository { get; }
        /// <summary>
        /// Repository to handle information about <see cref="TalentBase"/>
        /// </summary>
        ITalentBaseRepository TalentBaseRepository { get; }

        /// <summary>
        /// Initiates a transaction under the connection held an instance of UnitOfWork.
        /// </summary>
        /// <param name="isolationLevel">Transaction isolation level. Default: <see cref="IsolationLevel.ReadUncommitted"/>.</param>
        Task BeginTransactionAsync();

        /// <summary>
        /// Commits the transaction.
        /// </summary>
        Task CommitTransactionAsync();

        /// <summary>
        /// Rolls back the transaction.
        /// </summary>
        void RollbackTransaction();

    }
}
