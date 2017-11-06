using Application.Dtos;
using System.Collections.Generic;

namespace Application.Service.Abstract
{
    public interface IEmploymentService
    {
        IEnumerable<EmploymentDto> GetAll();
    }
}
