using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class EmploymentConfiguration : EntityTypeConfiguration<Employment>
    {
        public EmploymentConfiguration()
        {
            Property(e => e.FullName)
            .IsRequired()
            .HasMaxLength(100);

            Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(100);

            Property(e => e.Phone)
            .IsRequired()
            .HasMaxLength(10);

            Property(e => e.ManagerEmail)
            .IsRequired()
            .HasMaxLength(100);

            Property(e => e.RestrictedAccess)
                .HasMaxLength(255);

            Property(e => e.AdditionalInfo)
            .HasMaxLength(255);

            Property(e => e.AdditionalService)
            .HasMaxLength(255);

            Property(e => e.OtherPosition)
                .HasMaxLength(255);

            Property(e => e.OtherCompany)
            .HasMaxLength(255);

            Property(e => e.OtherAccesses)
            .HasMaxLength(255);

            Property(e => e.OtherServices)
            .HasMaxLength(255);

            HasRequired(e => e.Company)
            .WithMany(e => e.Employments)
            .HasForeignKey(e => e.CompanyId);

            HasRequired(e => e.Position)
            .WithMany(e => e.Employments)
            .HasForeignKey(e => e.PositionId);

            //HasMany(e => e.Accesses)
            //.WithMany(e => e.Employments)
            //.Map(m =>
            //{
            //    m.ToTable("EmploymentAccesses");
            //    m.MapLeftKey("EmploymentId");
            //    m.MapRightKey("AccessId");
            //});

            //HasMany(e => e.Equipments)
            //.WithMany(e => e.Employments)
            //.Map(m =>
            //{
            //    m.ToTable("EmploymentEquipments");
            //    m.MapLeftKey("EmploymentId");
            //    m.MapRightKey("EquipmentId");
            //});
        }
    }
}
