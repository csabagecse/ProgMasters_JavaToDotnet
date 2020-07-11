using ProgMasters.Mordor.Izek.API.Dto;
using ProgMasters.Mordor.Izek.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgMasters.Mordor.Izek.API.Mapper
{
    public class OrkMapper : IOrkMapper
    {
        public Dto.Ork MapToDto(Domain.Ork ork) 
        {
            return new Dto.Ork
            {
                Id = ork.Id,
                KillCount = ork.KillCount,
                Name = ork.Name,
                Weapons = ork.Weapons.Select(w => w.ToString()).ToList()
            };
        }

        public Domain.Ork MapToDomain(Dto.Ork ork)
        {
            return new Domain.Ork
            {
                Id = ork.Id,
                KillCount = ork.KillCount,
                Name = ork.Name,
                Weapons = ork.Weapons.Select(w => Enum.Parse<Weapon>(w)).ToList()
            };
        }
    }
}
