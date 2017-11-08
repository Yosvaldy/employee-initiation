﻿using Application.Model.Entities;
using System;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class EmploymentDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime StartDate { get; set; }
        public string ManagerEmail { get; set; }

        public string RestrictedAccess { get; set; }
        public string AdditionalInfo { get; set; }
        public string AdditionalService { get; set; }

        public string OtherPosition { get; set; }
        public string OtherComapny { get; set; }
        public string OtherAccesses { get; set; }
        public string OtherServices { get; set; }

        public int CompanyId { get; set; }

        public int PositionId { get; set; }

        public ICollection<Access> Accesses { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
    }
}
