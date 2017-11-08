using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class AccessConfiguration : EntityTypeConfiguration<Access>
    {
        public AccessConfiguration()
        {
                Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
