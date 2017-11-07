using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Application.Dtos
{
    public class EmploymentDto
    {
        public int EmploymentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public string ManagerEmail { get; set; }

        public string RestrictedAccess { get; set; }
        public string AdditionalInfoUserAccess { get; set; }
        public string AdditionalService { get; set; }

        public string PositionOtherDescription { get; set; }
        public string CompanyOtherDescription { get; set; }
        public string AccessLevelOtherDescription { get; set; }
        public string ServiceEquipmentOtherdescription { get; set; }

        public int PositionId { get; set; }
        //public PositionDto Position { get; set; }

        public int CompanyId { get; set; }
        //public CompanyDto Company { get; set; }

        public ICollection<AccessLevelDto> AccessLevels { get; set; }
        public ICollection<ServiceEquipmentDto> ServiceEquipments { get; set; }

        public EmploymentDto()
        {
            AccessLevels = new Collection<AccessLevelDto>();
            ServiceEquipments = new Collection<ServiceEquipmentDto>();
        }
    }
}
