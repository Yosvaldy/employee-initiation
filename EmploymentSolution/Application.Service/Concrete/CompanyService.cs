﻿using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Infrastructure;
using Application.Dtos;
using Application.Model.Entities;
using Application.Service.Abstract;
using Application.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Concrete
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository company;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public CompanyService(ICompanyRepository company, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.company = company;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<CompanyDto> GetAll()
        {
            return company.GetAll().Select(mapper.Map<Company, CompanyDto>);
        }
    }
}