namespace Application.Model.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int EmploymentId { get; set; }
        public Employment Employment { get; set; }
    }
}
