using Application.Dtos;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Abstract
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDto> GetAll();
    }
}
