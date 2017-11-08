using Application.Dtos;
using System.Collections.Generic;

namespace Application.Service.Abstract
{
    public interface IEmploymentService
    {
        IEnumerable<EmploymentDto> GetAll();
        EmploymentDto GetById(int id);
        void Create(EmploymentDto e);
        void Update(EmploymentDto e);
        void Delete(int id);
    }
}
