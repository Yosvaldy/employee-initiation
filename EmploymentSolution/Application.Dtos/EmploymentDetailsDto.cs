using System;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class EmploymentDetailsDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //public EmployeeDto Employee { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }

        public string ManagerEmail { get; set; }
        public string RestrictedAccess { get; set; }
        public string AdditionalInfo { get; set; }
        public string AdditionalService { get; set; }
        public string OtherPosition { get; set; }
        public string OtherComapny { get; set; }
        public string OtherAccesses { get; set; }
        public string OtherServices { get; set; }

        public string Company { get; set; }
        public string Position { get; set; }

        public ICollection<string> Accesses { get; set; }
        public ICollection<string> Equipments { get; set; }

        public EmploymentDetailsDto()
        {
            Accesses = new List<string>();
            Equipments = new List<string>();
        }
    }
}
