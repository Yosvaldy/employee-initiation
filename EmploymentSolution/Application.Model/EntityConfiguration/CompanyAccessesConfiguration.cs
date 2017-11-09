using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class CompanyAccessesConfiguration : EntityTypeConfiguration<CompanyAccesses>
    {
        public CompanyAccessesConfiguration()
        {
            HasKey(e => new { e.CompanyId, e.AccessId });
        }
    }
}
