namespace Application.Dtos
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RestrictedAccess { get; set; }
        public string AdditionalInfoUserAccess { get; set; }
        public string AdditionalService { get; set; }
    }
}
