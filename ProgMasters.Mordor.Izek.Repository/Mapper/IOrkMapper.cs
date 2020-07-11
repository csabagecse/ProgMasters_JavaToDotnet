using ProgMasters.Mordor.Izek.Domain;
using ProgMasters.Mordor.Izek.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository.Mapper
{
    public interface IOrkMapper
    {
        DbOrk MapToEntity(Ork ork);

        Ork MapToDomain(DbOrk ork);
    }
}
