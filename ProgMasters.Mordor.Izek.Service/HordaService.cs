using ProgMasters.Mordor.Izek.Domain;
using ProgMasters.Mordor.Izek.Repository.Abstractions;
using ProgMasters.Mordor.Izek.Service.Abstractions;
using System;
using System.Collections.Generic;

namespace ProgMasters.Mordor.Izek.Service
{
    public class HordaService : IHordaService
    {
        private readonly IHordaRepository hordaRepository;

        public HordaService(IHordaRepository hordaRepository)
        {
            this.hordaRepository = hordaRepository;
        }


        public IEnumerable<Horda> GetAll()
        {
        }
    }
}
