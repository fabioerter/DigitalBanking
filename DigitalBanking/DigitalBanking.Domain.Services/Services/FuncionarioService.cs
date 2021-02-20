using FluentValidation;
using DigitalBanking.Domain.Core.Interfaces.Repositories;
using DigitalBanking.Domain.Core.Interfaces.Services;
using DigitalBanking.Domain.Entities;
using DigitalBanking.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBanking.Domain.Services.Services
{
    public class FuncionarioService : Service<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(IUnitOfWork context, IFuncionarioRepository FuncionarioRepository) : base(context, FuncionarioRepository)
        {
            Validator = new FuncionarioValidator();
        }
    }
}
