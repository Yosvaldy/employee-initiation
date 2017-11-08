namespace Application.Model.Entities
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Services")]
    public class Equipment
    {
        public Equipment()
        {
            Employments = new Collection<Employment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employment> Employments { get; set; }
    }
}
