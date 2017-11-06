using Application.Dtos;
using System.Collections.Generic;

namespace Application.Service.Abstract
{
    public interface IAccessLevelService
    {
        IEnumerable<AccessLevelDto> GetAll();
    }
}
