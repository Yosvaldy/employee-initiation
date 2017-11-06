using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Infrastructure;
using Application.Dtos;
using Application.Service.Abstract;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service.Concrete
{
    class EmploymentService : IEmploymentService
    {
        private IEmploymentRepository employment;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public EmploymentService(IEmploymentRepository employment, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.employment = employment;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<EmploymentDto> GetAll()
        {
            return employment.GetAll().Select(mapper.Map<EmploymentDto>);
        }
    }
}
