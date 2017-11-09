using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class EmploymentDto
    {
        public int Id { get; set; }

        public EmployeeDto Employee { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public string ManagerEmail { get; set; }

        public string RestrictedAccess { get; set; }
        public string AdditionalInfo { get; set; }
        public string AdditionalService { get; set; }

        public string OtherPosition { get; set; }
        public string OtherComapny { get; set; }
        public string OtherAccesses { get; set; }
        public string OtherServices { get; set; }

        public int CompanyId { get; set; }

        public int PositionId { get; set; }

        public ICollection<int> Accesses { get; set; }
        public ICollection<int> Equipments { get; set; }

        public EmploymentDto()
        {
            Accesses = new Collection<int>();
            Equipments = new Collection<int>();
        }
    }
}
