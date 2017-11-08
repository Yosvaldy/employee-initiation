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
    class EmploymentService : IEmploymentService
    {
        private IEmploymentRepository repository;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public EmploymentService(IEmploymentRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<EmploymentDto> GetAll()
        {
            return repository.GetAll().Select(mapper.Map<EmploymentDto>).ToList();
        }

        public EmploymentDto GetById(int id)
        {
            var employ = repository.GetById(id);
            return mapper.Map<EmploymentDto>(employ);
        }

        public void Create(EmploymentDto e)
        {
            Employment emp = mapper.Map<Employment>(e);
            repository.Create(emp);
            unitOfWork.Commit();
        }

        public void Update(EmploymentDto e)
        {
            Employment emp = mapper.Map<Employment>(e);
            repository.Update(emp);
            unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
            unitOfWork.Commit();
        }
    }
}
