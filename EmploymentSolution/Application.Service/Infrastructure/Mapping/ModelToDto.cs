using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CreateMap<Company, CompanyDto>();
        }
    }
}
