using DigitalBanking.Domain.Core.Interfaces.Repositories;
using DigitalBanking.Domain.Entities;
using DigitalBanking.Infra.Data.Context;

namespace DigitalBanking.Infra.Data.Repositories
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {

        public EstadoRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
