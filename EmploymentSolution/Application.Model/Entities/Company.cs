namespace Application.Model.Entities
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Companies")]
    public class Company
    {
        public Company()
        {
            Employments = new Collection<Employment>();
            Accesses = new Collection<Access>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employment> Employments { get; set; }
        public ICollection<Access> Accesses { get; set; }
    }
}
