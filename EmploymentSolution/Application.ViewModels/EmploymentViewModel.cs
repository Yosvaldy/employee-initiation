using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class EmploymentViewModel
    {
        public int EmploymentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ManagerEmail { get; set; }

        public virtual EmployeeViewModel Employee { get; set; }

        public virtual IEnumerable<EmploymentAdditionalService> EmploymentAdditionalServices { get; set; }
        public virtual IEnumerable<EmploymentCompanyAccessLevel> EmploymentCompanyAccessLevels { get; set; }
        public virtual IEnumerable<EmploymentOtherPosition> EmploymentOtherPositions { get; set; }
        public virtual IEnumerable<EmploymentPosition> EmploymentPositions { get; set; }
        public virtual IEnumerable<EmploymentServiceEquipment> EmploymentServiceEquipments { get; set; }
    }
}
