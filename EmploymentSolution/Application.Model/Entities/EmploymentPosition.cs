namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmploymentPosition")]
    public partial class EmploymentPosition
    {
        public int EmploymentPositionId { get; set; }

        public int EmploymentId { get; set; }

        public int PositionId { get; set; }

        public virtual Employment Employment { get; set; }

        public virtual Position Position { get; set; }
    }
}
