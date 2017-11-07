namespace Application.Model.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Companies")]
    public class Company
    {
        public Company()
        {
            Employments = new HashSet<Employment>();
            AccessLevels = new HashSet<AccessLevel>();
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }

        public ICollection<Employment> Employments { get; set; }
        public ICollection<AccessLevel> AccessLevels { get; set; }
    }
}
