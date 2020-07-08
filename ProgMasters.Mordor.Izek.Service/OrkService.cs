using ProgMasters.Mordor.Izek.Domain;
using ProgMasters.Mordor.Izek.Repository.Abstractions;
using ProgMasters.Mordor.Izek.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Service
{
    public class OrkService : IOrkService
    {
        private readonly IOrkRepository orkRepository;

        public OrkService(IOrkRepository orkRepository)
        {
            this.orkRepository = orkRepository;
        }

        public IEnumerable<Ork> GetAll()
        {
            return orkRepository.GetAll();
        }
    }
}
