using ProgMasters.Mordor.Izek.Domain;
using ProgMasters.Mordor.Izek.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgMasters.Mordor.Izek.Repository
{
    public class OrkRepository : IOrkRepository
    {
        private readonly IIzeContext izeContext;

        public OrkRepository(IIzeContext izeContext)
        {
            this.izeContext = izeContext;
        }

        public IEnumerable<Ork> GetAll()
        {
            return izeContext.Orkok.Select(o => mapper.Map(o));
        }

        public Ork GetByName(string name)
        {
            var ork = izeContext.Orkok.Where(o => o.Name == name).Single();
            return mapper.Map(ork);
        }
    }
}
