using Application.Dtos;
using System.Collections.Generic;

namespace Application.Service.Abstract
{
    public interface IEmploymentService
    {
        IEnumerable<EmploymentDto> GetAll();
        EmploymentDetailsDto GetById(int id);
        void Create(EmploymentSaveDto e);
        void Update(EmploymentSaveDto e);
        void Delete(int id);
    }
}
