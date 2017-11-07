namespace Application.Model.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

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
