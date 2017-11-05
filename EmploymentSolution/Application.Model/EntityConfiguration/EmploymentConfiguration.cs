using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.EntityConfiguration
{
    public class EmploymentConfiguration : EntityTypeConfiguration<Employment>
    {
        public EmploymentConfiguration()
        {
            Property(e => e.ManagerEmail)
            .IsRequired()
            .HasMaxLength(50);

            HasRequired(e => e.Position)
            .WithMany(e => e.Employments)
            .HasForeignKey(e => e.PositionId);

            HasRequired(e => e.Employee)
            .WithRequiredPrincipal(e => e.Employment);

            HasMany(e => e.AccessLevels)
            .WithMany(e => e.Employments)
            .Map(m => 
            {
                m.ToTable("EmploymentAccessLevels");
                m.MapLeftKey("EmploymentId");
                m.MapRightKey("AccessLevelId");
            });

            HasMany(e => e.ServiceEquipments)
            .WithMany(e => e.Employments)
            .Map(m => 
            {
                m.ToTable("EmploymentServices");
                m.MapLeftKey("EmploymentId");
                m.MapRightKey("ServiceEquipmentId");
            });
        }
    }
}
