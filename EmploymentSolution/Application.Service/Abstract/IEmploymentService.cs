using Application.Model.Entities;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Abstract
{
    public interface IEmploymentService
    {
        IEnumerable<EmploymentViewModel> GetAll();
    }
}
