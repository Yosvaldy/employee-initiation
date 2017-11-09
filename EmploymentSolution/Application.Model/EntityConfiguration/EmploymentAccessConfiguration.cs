using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class EmploymentAccessConfiguration : EntityTypeConfiguration<EmploymentAccess>
    {
        public EmploymentAccessConfiguration()
        {
            HasKey(e => new { e.EmploymentId, e.AccessId });
        }
    }
}
