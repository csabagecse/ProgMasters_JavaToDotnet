using Microsoft.EntityFrameworkCore;
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
    }
}
