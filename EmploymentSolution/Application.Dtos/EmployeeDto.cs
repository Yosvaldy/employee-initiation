using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class EmployeeDto
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
