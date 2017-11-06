using Application.Model.Entities;
using Application.ViewModels;
using AutoMapper;

namespace Application.Service.Infrastructure.Mapping
{
    public class ModelToViewModel : Profile
    {
        public ModelToViewModel()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<Employment, EmploymentViewModel>();
            CreateMap<Company, CompanyViewModel>();
        }
    }
}
