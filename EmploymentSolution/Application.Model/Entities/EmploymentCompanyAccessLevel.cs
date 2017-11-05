namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmploymentCompanyAccessLevel")]
    public partial class EmploymentCompanyAccessLevel
    {
        public int EmploymentCompanyAccessLevelId { get; set; }

        public int EmploymentId { get; set; }

        public int CompanyAccessLevelId { get; set; }

        public virtual CompanyAccessLevel CompanyAccessLevel { get; set; }

        public virtual Employment Employment { get; set; }
    }
}
