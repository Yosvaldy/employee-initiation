using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;

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
            CreateMap<Employment, EmploymentDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Position, PositionDto>();
            CreateMap<Equipment, EquipmentDto>();
            CreateMap<Access, AccessDto>();
        }
    }
}
