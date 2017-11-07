using Application.Dtos;
using System.Collections.Generic;

namespace Application.Service.Abstract
{
    public interface IEmploymentService
    {
        IEnumerable<EmploymentDto> GetAll();
        EmploymentDto GetById(int id);
        void Create(EmploymentDto p);
        void Update(EmploymentDto p);
        void Delete(int id);
    }
}
