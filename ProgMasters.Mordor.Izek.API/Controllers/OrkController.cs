using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgMasters.Mordor.Izek.API.Dto;

namespace ProgMasters.Mordor.Izek.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrkController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Ork> Get()
        {
            return Enumerable.Empty<Ork>();
        }
    }
}
