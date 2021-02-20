using DigitalBanking.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBanking.Application.Interfaces
{
    public interface IPersonSampleAppService : IDisposable
    {
        PersonSampleDto Insert(PersonSampleDto personSampleDto);
        PersonSampleDto Update(Guid id, PersonSampleDto obj);
        void Delete(Guid id);
        IEnumerable<PersonSampleDto> GetAll();
        PersonSampleDto GetById(Guid Id);
    }
}
