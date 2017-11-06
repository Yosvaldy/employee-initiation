using Application.Dtos;
using System.Collections.Generic;

namespace Application.Service.Abstract
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAll();
    }
}
