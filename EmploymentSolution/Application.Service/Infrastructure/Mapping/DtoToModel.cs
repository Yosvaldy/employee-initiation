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
            CreateMap<EmploymentDto, Employment>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<CompanyDto, Company>();
            CreateMap<PositionDto, Position>();
            CreateMap<EquipmentDto, Equipment>();
            CreateMap<AccessDto, Access>();
        }
    }
}
