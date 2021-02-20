using AutoMapper;
using DigitalBanking.Application.Dtos;
using DigitalBanking.Domain.Entities;

namespace DigitalBanking.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<PersonSample, PersonSampleDto>();
        }
    }
}
