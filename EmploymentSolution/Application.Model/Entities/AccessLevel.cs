namespace Application.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessLevels")]
    public class AccessLevel
    {
        public AccessLevel()
        {
            Employments = new HashSet<Employment>();
            Companies = new HashSet<Company>();
        }

        public int AccessLevelId { get; set; }
        public string Name { get; set; }

        public ICollection<Employment> Employments { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
