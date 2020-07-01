using ProgMasters.Mordor.Izek.Domain;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace ProgMasters.Mordor.Izek.Service.Abstractions
{
    public interface IHordaService
    {
        IEnumerable<Horda> GetAll();
    }
}
