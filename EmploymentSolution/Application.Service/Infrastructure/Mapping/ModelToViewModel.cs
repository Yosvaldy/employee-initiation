using Application.Dtos;
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
    public class ModelToViewModel : Profile
    {
        public ModelToViewModel()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<Employment, EmploymentViewModel>();
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<Company, CompanyViewModel>();
        }
    }
}
