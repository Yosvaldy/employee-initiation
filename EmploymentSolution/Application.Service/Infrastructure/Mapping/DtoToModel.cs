using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;
using System.Linq;

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
            CreateMap<EmploymentDto, Employment>()
                .ForMember(c => c.FullName, opt => opt.MapFrom(cr => cr.Employee.FullName))
                .ForMember(c => c.Email, opt => opt.MapFrom(cr => cr.Employee.Email))
                .ForMember(c => c.Phone, opt => opt.MapFrom(cr => cr.Employee.Phone))
                .ForMember(c => c.Accesses, opt => opt.MapFrom(cr => cr.Accesses.Select(id => new EmploymentAccess { AccessId = id})))
                .ForMember(c => c.Equipments, opt => opt.MapFrom(cr => cr.Equipments.Select(id => new EmploymentEquipment { EquipmentId = id})));

            CreateMap<CompanyDto, Company>();
            CreateMap<PositionDto, Position>();
            CreateMap<EquipmentDto, Equipment>();
            CreateMap<AccessDto, Access>();
        }
    }
}
