using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Domain
{
    public class Ork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Weapon> Weapons { get; set; }
        public int KillCount { get; set; }
    }
}
