using AutoMapper;
using DigitalBanking.Application.Dtos;
using DigitalBanking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBanking.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<FuncionarioDto, Funcionario>();
        }
    }
}
