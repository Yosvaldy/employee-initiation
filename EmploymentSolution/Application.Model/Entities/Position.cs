namespace Application.Model.Entities
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Positions")]
    public class Position
    {
        public Position()
        {
            Employments = new Collection<Employment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employment> Employments { get; set; }
    }
}
