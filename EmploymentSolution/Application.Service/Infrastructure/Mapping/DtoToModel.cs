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
        }
    }
}
