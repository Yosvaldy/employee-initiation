using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Infrastructure;
using Application.Dtos;
using Application.Model.Entities;
using Application.Service.Abstract;
using AutoMapper;
using System;
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
            var employment = repository.GetById(id);
            return mapper.Map<EmploymentDto>(employment);
        }

        public void Create(EmploymentDto employment)
        {
            var emp = mapper.Map<Employment>(employment);
            emp.CreatedDate = DateTime.Now;
            repository.Create(emp);
            unitOfWork.Commit();
        }

        public void Update(EmploymentDto employmentDto)
        {
            var employment = repository.GetById(employmentDto.Id);
            var emp = mapper.Map(employmentDto, employment);
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
