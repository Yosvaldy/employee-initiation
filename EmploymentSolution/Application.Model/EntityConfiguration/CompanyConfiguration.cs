using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.EntityConfiguration
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
                Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

                HasMany(e => e.AccessLevels)
                .WithMany(e => e.Companies)
                .Map(m => 
                {
                    m.ToTable("CompanyAccessLevels");
                    m.MapLeftKey("CompanyId");
                    m.MapRightKey("AccessLevelId");
                });
        }
    }
}
