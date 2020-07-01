using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgMasters.Mordor.Izek.API.Dto
{
    public class Ork
    {
        public string Name { get; set; }
        public List<Weapon> Weapons { get; set; }
        public int KillCount { get; set; }
    }
}
