using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class EmploymentSaveDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone { get; set; }

        //public EmployeeDto Employee { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        [StringLength(100)]
        public string ManagerEmail { get; set; }

        [StringLength(255)]
        public string RestrictedAccess { get; set; }

        [StringLength(255)]
        public string AdditionalInfo { get; set; }

        [StringLength(255)]
        public string AdditionalService { get; set; }

        [StringLength(255)]
        public string OtherPosition { get; set; }

        [StringLength(255)]
        public string OtherComapny { get; set; }

        [StringLength(255)]
        public string OtherAccesses { get; set; }

        [StringLength(255)]
        public string OtherServices { get; set; }

        public int CompanyId { get; set; }

        public int PositionId { get; set; }

        public IEnumerable<int> Accesses { get; set; }
        public IEnumerable<int> Equipments { get; set; }

        public EmploymentSaveDto()
        {
            Accesses = new List<int>();
            Equipments = new List<int>();
        }
    }
}
