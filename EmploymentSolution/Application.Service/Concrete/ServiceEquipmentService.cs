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
    public class ServiceEquipmentService : IServiceEquipmentService
    {
        private IServiceEquipmentRepository serviceEquipment;
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public ServiceEquipmentService(IServiceEquipmentRepository servEquipment, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.serviceEquipment = servEquipment;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<ServiceEquipmentDto> GetAll()
        {
            return serviceEquipment.GetAll().Select(mapper.Map<ServiceEquipment, ServiceEquipmentDto>);
        }
    }
}
