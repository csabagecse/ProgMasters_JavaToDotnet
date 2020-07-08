using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository.Entities
{
    public class DbOrk
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int KillCount { get; set; }

        public List<DbOrkWeapon> Weapons { get; set; }
    }
}
