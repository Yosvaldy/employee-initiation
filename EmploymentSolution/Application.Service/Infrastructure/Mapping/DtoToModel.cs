using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;

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
            CreateMap<CompanyDto, Company>()
                .ForMember(c => c.CompanyId, opt => opt.Ignore());   //Just in Case you Update the Company, ignore change id.

            CreateMap<PositionDto, Position>()
                .ForMember(c => c.PositionId, opt => opt.Ignore());

            CreateMap<ServiceEquipmentDto, ServiceEquipment>()
                .ForMember(c => c.ServiceEquipmentId, opt => opt.Ignore());

            CreateMap<AccessLevelDto, AccessLevel>()
                .ForMember(c => c.AccessLevelId, opt => opt.Ignore());

            CreateMap<EmployeeDto, Employee>()
                .ForMember(c => c.EmployeeId, opt => opt.Ignore());

            CreateMap<EmployeeDto, Employee>()
                .ForMember(c => c.EmployeeId, opt => opt.Ignore());
        }
    }
}
