using ProgMasters.Mordor.Izek.Domain;
using ProgMasters.Mordor.Izek.Repository.Abstractions;
using ProgMasters.Mordor.Izek.Repository.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgMasters.Mordor.Izek.Repository
{
    public class OrkRepository : IOrkRepository
    {
        private readonly IOrkMapper mapper;

        public OrkRepository(IOrkMapper mapper)
        {
            this.mapper = mapper;
        }

        public IEnumerable<Ork> GetAll()
        {
            using var ctx = new IzeContext();
            return ctx.Orkok.Select(o => mapper.MapToDomain(o)).ToList();
        }

        public Ork GetByName(string name)
        {
            using var ctx = new IzeContext();
            var ork = ctx.Orkok.Where(o => o.Name == name).Single();
            return mapper.MapToDomain(ork);
        }
    }
}
