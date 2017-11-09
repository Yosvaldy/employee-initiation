using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class EmploymentEquipmentConfiguration : EntityTypeConfiguration<EmploymentEquipment>
    {
        public EmploymentEquipmentConfiguration()
        {
            HasKey(e => new { e.EmploymentId, e.EquipmentId });
        }
    }
}
