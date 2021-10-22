using AutoMapper;
using Eureka.Application.DTO;
using Eureka.Domain.Model;

namespace Eureka.Application.Application
{
    public class ApplicationMapperProfile : Profile
    {
        public ApplicationMapperProfile()
        {
            CreateMap<Crud, CrudDto>()
                .ReverseMap();
        }
    }
}
