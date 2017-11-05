namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employment")]
    public partial class Employment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employment()
        {
            EmploymentAdditionalServices = new HashSet<EmploymentAdditionalService>();
            EmploymentCompanyAccessLevels = new HashSet<EmploymentCompanyAccessLevel>();
            EmploymentOtherPositions = new HashSet<EmploymentOtherPosition>();
            EmploymentPositions = new HashSet<EmploymentPosition>();
            EmploymentServiceEquipments = new HashSet<EmploymentServiceEquipment>();
        }

        public int EmploymentId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ManagerEmail { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentAdditionalService> EmploymentAdditionalServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentCompanyAccessLevel> EmploymentCompanyAccessLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentOtherPosition> EmploymentOtherPositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentPosition> EmploymentPositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentServiceEquipment> EmploymentServiceEquipments { get; set; }
    }
}
