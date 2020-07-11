using ProgMasters.Mordor.Izek.Domain;
using ProgMasters.Mordor.Izek.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository.Mapper
{
    public class OrkMapper : IOrkMapper
    {
        public Ork MapToDomain(DbOrk ork)
        {
            var mapped = new Ork
            {
                Id = ork.Id,
                Name = ork.Name,
                KillCount = ork.KillCount,
                Weapons = (ork.Weapons ?? new List<DbOrkWeapon>()).Select(w => Enum.Parse<Weapon>(w.Weapon)).ToList()
            };

            return mapped;
        }

        public DbOrk MapToEntity(Ork ork)
        {
            var mapped = new DbOrk
            {
                Id = ork.Id,
                Name = ork.Name,
                KillCount = ork.KillCount,
                Weapons = ork.Weapons.Select(w => new DbOrkWeapon
                {
                    Weapon = w.ToString()
                }).ToList()
            };

            return mapped;
        }
    }
}
