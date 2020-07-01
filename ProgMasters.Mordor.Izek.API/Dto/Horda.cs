using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgMasters.Mordor.Izek.API.Dto
{
    public class Horda
    {
        public string Name { get; set; }

        public List<Ork> Orks { get; set; }

        public DateTime LastFight { get; set; }

    }
}
