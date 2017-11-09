namespace Application.Model.Entities
{
    public class EmploymentEquipment
    {
        public int EmploymentId { get; set; }
        public int EquipmentId { get; set; }

        public Employment Employment { get; set; }
        public Equipment Equipment { get; set; }
    }
}
