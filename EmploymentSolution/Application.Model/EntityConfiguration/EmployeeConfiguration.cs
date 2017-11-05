using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.EntityConfiguration
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
                Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(50);

                Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50);

                Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(10);

                Property(e => e.RestrictedAccess)
                .HasMaxLength(255);

                Property(e => e.AdditionalInfoUserAccess)
                .HasMaxLength(255);

                Property(e => e.AdditionalService)
                .HasMaxLength(255);
        }
    }
}
