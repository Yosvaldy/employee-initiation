namespace Application.Model.Entities
{
    public class CompanyAccesses
    {
        public int CompanyId { get; set; }
        public int AccessId { get; set; }

        public Company Company { get; set; }
        public Access Access { get; set; }
    }
}
