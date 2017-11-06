using Application.Model.Entities;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class CompanyDto
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }

        public ICollection<AccessLevel> AccessLevels { get; set; }
    }
}
