using AutoMapper;
using DigitalBanking.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBanking.Application.Base
{
    public abstract class AppService
    {
        public AppService(IUnitOfWork uoW, IMapper Mapper)
        {
            UoW = uoW;
            this.Mapper = Mapper;
        }

        protected IUnitOfWork UoW { get; set; }
        protected IMapper Mapper { get; set; }
    }
}
