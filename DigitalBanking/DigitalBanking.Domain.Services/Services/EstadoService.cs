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
    public class EstadoService : Service<Estado>, IEstadoService
    {
        public EstadoService(IUnitOfWork context, IEstadoRepository EstadoRepository) : base(context, EstadoRepository)
        {
            Validator = new EstadoValidator();
        }
    }
}
