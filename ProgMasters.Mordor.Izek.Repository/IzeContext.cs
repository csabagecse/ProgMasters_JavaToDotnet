using Microsoft.EntityFrameworkCore;
using ProgMasters.Mordor.Izek.Repository.Config;
using ProgMasters.Mordor.Izek.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository
{
    public class IzeContext : DbContext, IIzeContext
    {
        public DbSet<DbOrk> Orkok { get; set; }

        public DbSet<DbHorda> Hordak { get; set; }

        public DbSet<DbOrkWeapon> OrkWeapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySQL("server=localhost;database=ize;user=progmasters;password=progmasters");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DbOrkConfig());
            modelBuilder.ApplyConfiguration(new DbHordaConfig());
        }
    }
}
