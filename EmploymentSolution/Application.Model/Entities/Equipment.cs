namespace Application.Model.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Equipments")]
    public class Equipment
    {
        //public Equipment()
        //{
        //    Employments = new Collection<Employment>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        //public ICollection<Employment> Employments { get; set; }
    }
}
