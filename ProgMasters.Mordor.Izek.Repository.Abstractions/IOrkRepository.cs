using ProgMasters.Mordor.Izek.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository.Abstractions
{
    public interface IOrkRepository
    {
        IEnumerable<Ork> GetAll();

        Ork GetByName(string name);
    }
}
