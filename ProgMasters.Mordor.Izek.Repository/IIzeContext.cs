using Microsoft.EntityFrameworkCore;
using ProgMasters.Mordor.Izek.Repository.Entities;

namespace ProgMasters.Mordor.Izek.Repository
{
    public interface IIzeContext
    {
        DbSet<DbHorda> Hordak { get; set; }
        DbSet<DbOrk> Orkok { get; set; }
        DbSet<DbOrkWeapon> OrkWeapons { get; set; }
    }
}