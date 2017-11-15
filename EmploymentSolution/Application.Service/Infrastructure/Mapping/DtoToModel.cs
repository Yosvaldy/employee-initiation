using Application.Dtos;
using Application.Model.Entities;
using Application.Service.Infrastructure.Resolvers;
using AutoMapper;
using System;

namespace Application.Service.Infrastructure.Mapping
{
    public class DtoToModel : Profile
    {
        public DtoToModel()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<EmploymentSaveDto, Employment>()
                .ForMember(m => m.CreatedDate, opt => opt.UseValue(DateTime.Now))
                .ForMember(m => m.Accesses, opt => opt.ResolveUsing<AccessesResolver>())
                .ForMember(m => m.Equipments, opt => opt.ResolveUsing<EquipmentsResolver>());
        }
    }
}
