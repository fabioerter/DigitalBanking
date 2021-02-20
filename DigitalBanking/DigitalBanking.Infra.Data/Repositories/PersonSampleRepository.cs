using DigitalBanking.Domain.Core.Interfaces.Repositories;
using DigitalBanking.Domain.Entities;
using DigitalBanking.Infra.Data.Context;

namespace DigitalBanking.Infra.Data.Repositories
{
    public class PersonSampleRepository : Repository<PersonSample>, IPersonSampleRepository
    {

        public PersonSampleRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
