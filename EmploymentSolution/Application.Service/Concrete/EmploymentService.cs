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
        private IAccessRepository accRepository; 
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public EmploymentService(IEmploymentRepository repository, IUnitOfWork unitOfWork, IMapper mapper, IAccessRepository accRepository)
        {
            this.repository = repository;
            this.accRepository = accRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<EmploymentDto> GetAll()
        {
            return repository.GetAll().Select(mapper.Map<EmploymentDto>).ToList();
        }

        public EmploymentDetailsDto GetById(int id)
        {
            var employment = repository.GetById(id);
            return mapper.Map<EmploymentDetailsDto>(employment);
        }

        public void Create(EmploymentSaveDto employment)
        {
            Employment emp = mapper.Map<EmploymentSaveDto, Employment>(employment);
            //emp.CreatedDate = DateTime.Now;
            repository.Create(emp);
            unitOfWork.Commit();
            employment.Id = emp.Id;
        }

        public void Update(EmploymentSaveDto employment)
        {
            Employment emp = mapper.Map<Employment>(employment);
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
