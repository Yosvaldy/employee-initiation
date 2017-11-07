namespace Application.Model.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Positions")]
    public class Position
    {
        public Position()
        {
            Employments = new HashSet<Employment>();
        }

        public int PositionId { get; set; }
        public string Name { get; set; }

        public ICollection<Employment> Employments { get; set; }
    }
}
