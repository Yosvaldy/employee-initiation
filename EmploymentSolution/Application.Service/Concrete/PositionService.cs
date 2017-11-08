﻿using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Infrastructure;
using Application.Dtos;
using Application.Model.Entities;
using Application.Service.Abstract;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service.Concrete
{
    public class PositionService : IPositionService
    {
        private IPositionRepository repository;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public PositionService(IPositionRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<PositionDto> GetAll()
        {
            return repository.GetAll().Select(mapper.Map<Position, PositionDto>).ToList();
        }
    }
}
