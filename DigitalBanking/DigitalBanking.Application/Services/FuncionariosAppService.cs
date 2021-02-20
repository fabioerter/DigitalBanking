using AutoMapper;
using DigitalBanking.Application.Base;
using DigitalBanking.Application.Dtos;
using DigitalBanking.Application.Interfaces;
using DigitalBanking.Domain.Core.Interfaces.Repositories;
using DigitalBanking.Domain.Core.Interfaces.Services;
using DigitalBanking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalBanking.Application.Services
{
    public class FuncionarioAppService : AppService, IFuncionarioAppService
    {
        private readonly IMapper _mapper;
        private readonly IFuncionarioService _serviceFuncionario;
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioAppService(IUnitOfWork uoW, IMapper mapper, IFuncionarioService serviceFuncionario,
            IFuncionarioRepository funcionarioRepository) : base(uoW, mapper)
        {
            _mapper = mapper;
            _serviceFuncionario = serviceFuncionario;
            _funcionarioRepository = funcionarioRepository;
        }

        public FuncionarioDto Insert(FuncionarioDto obj)
        {

            try
            {
                UoW.BeginTransaction();
                var Funcionario = _serviceFuncionario.Insert(Mapper.Map<Funcionario>(obj));
                UoW.Commit();

                return Mapper.Map<FuncionarioDto>(Funcionario);
            }
            catch (Exception ex)
            {
                UoW.Rollback();
                throw ex;
            }
        }

        public FuncionarioDto Update(int id, FuncionarioDto obj)
        {
            try
            {
                UoW.BeginTransaction();

                var Funcionario = Mapper.Map<Funcionario>(obj);
                Funcionario.Id = id;
                Funcionario = _serviceFuncionario.Update(Funcionario);

                UoW.Commit();
                return Mapper.Map<FuncionarioDto>(Funcionario);
            }
            catch (Exception ex)
            {
                UoW.Rollback();
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                UoW.BeginTransaction();
                var obj = _serviceFuncionario.GetById(id);
                _serviceFuncionario.Delete(Mapper.Map<Funcionario>(obj));

                UoW.Commit();
            }
            catch (Exception ex)
            {
                UoW.Rollback();
                throw ex;
            }
        }

        public IEnumerable<FuncionarioDto> GetAll()
        {
            return _mapper.Map<IEnumerable<FuncionarioDto>>(_serviceFuncionario.GetAll());
        }

        public FuncionarioDto GetById(int Id)
        {
            return _mapper.Map<FuncionarioDto>(_serviceFuncionario.GetById(Id));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
