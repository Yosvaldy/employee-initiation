using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Application.Service.Infrastructure.Resolvers
{
    class EquipmentsResolver : IValueResolver<EmploymentSaveDto, Employment, ICollection<EmploymentEquipment>>
    {
        public ICollection<EmploymentEquipment> Resolve(EmploymentSaveDto source, Employment destination, ICollection<EmploymentEquipment> destMember, ResolutionContext context)
        {
            var result = new Collection<EmploymentEquipment>();
            source.Equipments.ToList().ForEach(equipmentId =>
            {
                result.Add(new EmploymentEquipment
                {
                    EquipmentId = equipmentId,
                    EmploymentId = source.Id
                });
            });

            return result;
        }
    }
}
