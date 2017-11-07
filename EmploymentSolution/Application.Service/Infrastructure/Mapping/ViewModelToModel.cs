using Application.Model.Entities;
using Application.ViewModels;
using AutoMapper;

namespace Application.Service.Infrastructure.Mapping
{
    public class ViewModelToModel : Profile
    {
        public ViewModelToModel()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<EmploymentViewModel, Employment>();
        }
    }
}
