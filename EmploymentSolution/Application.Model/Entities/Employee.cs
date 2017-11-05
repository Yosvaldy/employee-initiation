namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RestrictedAccess { get; set; }
        public string AdditionalInfoUserAccess { get; set; }
        public string AdditionalService { get; set; }

        public int EmploymentId { get; set; }
        public Employment Employment { get; set; }
    }
}
