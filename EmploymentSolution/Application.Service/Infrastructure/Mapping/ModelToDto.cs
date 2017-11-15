using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;
using System.Linq;

namespace Application.Service.Infrastructure.Mapping
{
    public class ModelToDto : Profile
    {
        public ModelToDto()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<Employment, EmploymentDto>()
                .ForMember(dto => dto.Position, action => action.MapFrom(m => m.Position.Name))
                .ForMember(dto => dto.Company, action => action.MapFrom(m => m.Company.Name));


            CreateMap<Employment, EmploymentDetailsDto>()
                .ForMember(dto => dto.Position, action => action.MapFrom(m => m.Position.Name))
                .ForMember(dto => dto.Company, action => action.MapFrom(m => m.Company.Name))
                .ForMember(dto => dto.Accesses, action => action.MapFrom(m => m.Accesses.Select(s => s.Access.Name)))
                .ForMember(dto => dto.Equipments, action => action.MapFrom(m => m.Equipments.Select(s => s.Equipment.Name)));


            CreateMap<Company, CompanyDto>();
            CreateMap<Position, PositionDto>();
            CreateMap<Equipment, EquipmentDto>();
            CreateMap<Access, AccessDto>();
        }
    }
}
