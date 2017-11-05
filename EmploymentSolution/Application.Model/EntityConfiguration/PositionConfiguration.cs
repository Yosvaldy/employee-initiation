using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.EntityConfiguration
{
    public class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}
