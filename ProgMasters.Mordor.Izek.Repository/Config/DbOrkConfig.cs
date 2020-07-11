using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgMasters.Mordor.Izek.Domain;
using ProgMasters.Mordor.Izek.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository.Config
{
    public class DbOrkConfig : IEntityTypeConfiguration<DbOrk>
    {
        public void Configure(EntityTypeBuilder<DbOrk> builder)
        {
            builder.ToTable("OrkTable");

            builder.HasKey(ork => ork.Id);

            builder.Property(ork => ork.Name)
                .IsRequired();

            builder.HasIndex(ork => ork.Name)
                .IsUnique();
        }
    }
}
