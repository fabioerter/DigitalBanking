using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace DigitalBanking.Domain.Core.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
        Guid Id { get; }
        IDbTransaction Transaction { get; }

        DbContext Context { get; set; }

        bool ValidateEntity { get; set; }

        void BeginTransaction();

        void Commit(bool dispose = true);

        void Rollback(bool dispose = true);

    }
}
