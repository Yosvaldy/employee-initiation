using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class EmployeeDto
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone { get; set; }
    }
}
