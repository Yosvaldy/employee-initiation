namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employments")]
    public class Employment
    {
        public Employment()
        {
            AccessLevels = new HashSet<AccessLevel>();
            ServiceEquipments = new HashSet<ServiceEquipment>();
        }

        public int EmploymentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public string ManagerEmail { get; set; }

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
