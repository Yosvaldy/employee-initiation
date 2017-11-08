using Application.Dtos;
using System.Collections.Generic;

namespace Application.Service.Abstract
{
    public interface IEquipmentService
    {
        IEnumerable<EquipmentDto> GetAll();
    }
}
