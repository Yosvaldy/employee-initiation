namespace Application.Model.Entities
{
    public class EmploymentAccess
    {
        public int EmploymentId { get; set; }
        public int AccessId { get; set; }

        public Employment Employment { get; set; }
        public Access Access { get; set; }
    }
}
