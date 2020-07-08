using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgMasters.Mordor.Izek.API.Mapper
{
    public interface IOrkMapper
    {
        Dto.Ork MapToDto(Domain.Ork ork);

        Domain.Ork MapToDomain(Dto.Ork ork);
    }
}
