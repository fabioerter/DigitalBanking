using DigitalBanking.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBanking.Application.Interfaces
{
    public interface IFuncionarioAppService : IDisposable
    {
        FuncionarioDto Insert(FuncionarioDto funcionarioDto);
        FuncionarioDto Update(int id, FuncionarioDto funcionarioDto);
        void Delete(int id);
        IEnumerable<FuncionarioDto> GetAll();
        FuncionarioDto GetById(int Id);
    }
}
