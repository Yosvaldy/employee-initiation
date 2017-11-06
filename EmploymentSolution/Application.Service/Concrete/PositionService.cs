using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Infrastructure;
using Application.Dtos;
using Application.Model.Entities;
using Application.Service.Abstract;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Concrete
{
    public class PositionService : IPositionService
    {
        private IPositionRepository position;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public PositionService(IPositionRepository pos, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.position = pos;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<PositionDto> GetAll()
        {
            return position.GetAll().Select(mapper.Map<Position, PositionDto>);
        }
    }
}
