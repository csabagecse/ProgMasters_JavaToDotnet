using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgMasters.Mordor.Izek.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository.Config
{
    public class DbHordaConfig : IEntityTypeConfiguration<DbHorda>
    {
        public void Configure(EntityTypeBuilder<DbHorda> builder)
        {
            builder.HasKey(horda => horda.Id);
        }
    }
}
