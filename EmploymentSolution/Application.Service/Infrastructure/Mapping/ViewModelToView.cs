using Application.Model.Entities;
using Application.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Infrastructure.Mapping
{
    public class ViewModelToView : Profile
    {
        public ViewModelToView()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<EmploymentViewModel, Employment>();
            CreateMap<EmployeeViewModel, Employee>();
        }
    }
}
