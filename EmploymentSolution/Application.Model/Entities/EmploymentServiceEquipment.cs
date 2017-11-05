namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmploymentServiceEquipment")]
    public partial class EmploymentServiceEquipment
    {
        public int EmploymentServiceEquipmentId { get; set; }

        public int ServiceEquipmentId { get; set; }

        public int EmploymentId { get; set; }

        public virtual Employment Employment { get; set; }

        public virtual ServiceEquipment ServiceEquipment { get; set; }
    }
}
