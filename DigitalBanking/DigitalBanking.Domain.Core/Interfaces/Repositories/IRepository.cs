using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBanking.Domain.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {

        void Delete(int id);
        void Delete(TEntity obj);
        void DeleteAsync(TEntity obj);
        void DeleteRange(ICollection<TEntity> t);

        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);

        TEntity Insert(TEntity obj);
        Task<TEntity> InsertAsync(TEntity obj);
        TEntity Update(TEntity obj);
        Task<TEntity> UpdateAsync(TEntity obj);
        IEnumerable<TEntity> GetAll();

    }
}
