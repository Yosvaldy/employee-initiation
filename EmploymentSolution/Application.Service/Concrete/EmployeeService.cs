using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Infrastructure;
using Application.Dtos;
using Application.Model.Entities;
using Application.Service.Abstract;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employee;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public EmployeeService(IEmployeeRepository emplo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.employee = emplo;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            return employee.GetAll().Select(mapper.Map<Employee, EmployeeDto>);
        }
    }
}
