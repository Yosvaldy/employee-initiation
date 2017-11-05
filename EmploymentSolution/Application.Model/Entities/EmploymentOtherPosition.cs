namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmploymentOtherPosition")]
    public partial class EmploymentOtherPosition
    {
        public int EmploymentOtherPositionId { get; set; }

        public int EmploymentId { get; set; }

        [StringLength(10)]
        public string Description { get; set; }

        public virtual Employment Employment { get; set; }
    }
}
