namespace Application.Model.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Accesses")]
    public class Access
    {
        //public Access()
        //{
        //    //Employments = new Collection<Employment>();
        //    Companies = new Collection<Company>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        //public ICollection<Employment> Employments { get; set; }
        //public ICollection<Company> Companies { get; set; }
    }
}
