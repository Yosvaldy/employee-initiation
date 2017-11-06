using Application.Model.Entities;
using System;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class EmploymentDto
    {
        public int EmploymentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public string ManagerEmail { get; set; }

        public string RestrictedAccess { get; set; }
        public string AdditionalInfoUserAccess { get; set; }
        public string AdditionalService { get; set; }

        public string PositionOtherDescription { get; set; }
        public string CompanyOtherDescription { get; set; }
        public string AccessLevelOtherDescription { get; set; }
        public string ServiceEquipmentOtherdescription { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<AccessLevel> AccessLevels { get; set; }
        public ICollection<ServiceEquipment> ServiceEquipments { get; set; }
    }
}
