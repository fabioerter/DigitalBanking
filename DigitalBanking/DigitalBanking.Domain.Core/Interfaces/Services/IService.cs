using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBanking.Domain.Core.Interfaces.Services
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        void Delete(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        TEntity Insert(TEntity obj);
        TEntity Update(TEntity obj);
    }
}
