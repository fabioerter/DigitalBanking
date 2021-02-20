using DigitalBanking.Domain.Core.Interfaces.Repositories;
using DigitalBanking.Domain.Entities;
using DigitalBanking.Infra.Data.Context;

namespace DigitalBanking.Infra.Data.Repositories
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {

        public FuncionarioRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
