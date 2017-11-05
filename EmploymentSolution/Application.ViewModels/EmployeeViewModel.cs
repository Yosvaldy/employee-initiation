﻿using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string RestrictedAccess { get; set; }

        [StringLength(255)]
        public string AdditionalInfoUserAccess { get; set; }

        [StringLength(255)]
        public string AdditionalService { get; set; }

        public int EmploymentId { get; set; }
        public Employment Employment { get; set; }

        public virtual IEnumerable<Employment> Employments { get; set; }
    }
}
