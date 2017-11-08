using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
                Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

                HasMany(e => e.Accesses)
                .WithMany(e => e.Companies)
                .Map(m => 
                {
                    m.ToTable("CompanyAccesses");
                    m.MapLeftKey("CompanyId");
                    m.MapRightKey("AccessId");
                });
        }
    }
}
