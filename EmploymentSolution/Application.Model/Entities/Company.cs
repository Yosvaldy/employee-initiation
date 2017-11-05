namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
