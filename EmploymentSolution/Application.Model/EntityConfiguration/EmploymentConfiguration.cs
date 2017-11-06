using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class EmploymentConfiguration : EntityTypeConfiguration<Employment>
    {
        public EmploymentConfiguration()
        {
            Property(e => e.ManagerEmail)
            .IsRequired()
            .HasMaxLength(50);

            Property(e => e.RestrictedAccess)
                .HasMaxLength(255);

            Property(e => e.AdditionalInfoUserAccess)
            .HasMaxLength(255);

            Property(e => e.AdditionalService)
            .HasMaxLength(255);

            Property(e => e.PositionOtherDescription)
                .HasMaxLength(255);

            Property(e => e.CompanyOtherDescription)
            .HasMaxLength(255);

            Property(e => e.AccessLevelOtherDescription)
            .HasMaxLength(255);

            Property(e => e.ServiceEquipmentOtherdescription)
            .HasMaxLength(255);

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
