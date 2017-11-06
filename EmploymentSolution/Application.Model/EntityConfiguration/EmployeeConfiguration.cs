using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

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

                
        }
    }
}
