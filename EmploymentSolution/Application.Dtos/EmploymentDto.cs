namespace Application.Dtos
{
    public class EmploymentDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //public EmployeeDto Employee { get; set; }

        public string Company { get; set; }
        public string Position { get; set; }
    }
}
