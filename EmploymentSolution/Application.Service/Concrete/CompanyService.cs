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
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository repository;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public CompanyService(ICompanyRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<CompanyDto> GetAll()
        {
            return repository.GetAll().Select(mapper.Map<Company, CompanyDto>).ToList();
        }

        public CompanyDetailsDto GetById(int id)
        {
            var company = repository.GetById(id);
            return mapper.Map<Company, CompanyDetailsDto>(company);
        }
    }
}
