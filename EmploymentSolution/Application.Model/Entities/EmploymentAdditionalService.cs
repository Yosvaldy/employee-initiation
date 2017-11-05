namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmploymentAdditionalService")]
    public partial class EmploymentAdditionalService
    {
        public int EmploymentAdditionalServiceId { get; set; }

        public int EmploymentId { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public virtual Employment Employment { get; set; }
    }
}
