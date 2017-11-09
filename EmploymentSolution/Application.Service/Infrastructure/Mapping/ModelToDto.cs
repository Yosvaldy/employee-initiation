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
                .ForMember(cr => cr.Employee, opt => opt.MapFrom(c => new EmployeeDto { FullName = c.FullName, Email = c.Email, Phone = c.Phone }))
                .ForMember(cr => cr.Accesses, opt => opt.MapFrom(c => c.Accesses.Select(e => e.AccessId)))
                .ForMember(cr => cr.Equipments, opt => opt.MapFrom(c => c.Equipments.Select(e => e.EquipmentId)));

            CreateMap<Company, CompanyDto>();
            CreateMap<Position, PositionDto>();
            CreateMap<Equipment, EquipmentDto>();
            CreateMap<Access, AccessDto>();
        }
    }
}
