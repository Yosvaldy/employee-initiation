﻿using Application.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Application.Model.EntityConfiguration
{
    public class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}
