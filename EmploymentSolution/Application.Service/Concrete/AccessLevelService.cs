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
    public class AccessLevelService : IAccessLevelService
    {
        private IAccessLevelRepository access;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public AccessLevelService(IAccessLevelRepository access, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.access = access;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<AccessLevelDto> GetAll()
        {
            return access.GetAll().Select(mapper.Map<AccessLevel, AccessLevelDto>);
        }
    }
}
