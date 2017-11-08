using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class EquipmentConfiguration : EntityTypeConfiguration<Equipment>
    {
        public EquipmentConfiguration()
        {
            Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}
