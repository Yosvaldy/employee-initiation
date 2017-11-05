namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyAccessLevel")]
    public partial class CompanyAccessLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyAccessLevel()
        {
            EmploymentCompanyAccessLevels = new HashSet<EmploymentCompanyAccessLevel>();
        }

        public int CompanyAccessLevelId { get; set; }

        public int CompanyId { get; set; }

        public int AccessLevelId { get; set; }

        public virtual AccessLevel AccessLevel { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentCompanyAccessLevel> EmploymentCompanyAccessLevels { get; set; }
    }
}
