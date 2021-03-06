namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Employments")]
    public class Employment
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public string ManagerEmail { get; set; }

        public string RestrictedAccess { get; set; }
        public string AdditionalInfo { get; set; }
        public string AdditionalService { get; set; }

        public string OtherPosition { get; set; }
        public string OtherCompany { get; set; }
        public string OtherAccesses { get; set; }
        public string OtherServices { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public ICollection<EmploymentAccess> Accesses { get; set; }
        public ICollection<EmploymentEquipment> Equipments { get; set; }

        public Employment()
        {
            Accesses = new Collection<EmploymentAccess>();
            Equipments = new Collection<EmploymentEquipment>();
        }
    }
}
