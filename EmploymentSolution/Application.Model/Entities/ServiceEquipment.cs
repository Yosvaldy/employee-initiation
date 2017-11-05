namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceEquipments")]
    public class ServiceEquipment
    {
        public ServiceEquipment()
        {
            Employments = new HashSet<Employment>();
        }

        public int ServiceEquipmentId { get; set; }
        public string Name { get; set; }

        public ICollection<Employment> Employments { get; set; }
    }
}
