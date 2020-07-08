using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgMasters.Mordor.Izek.API.Dto;
using ProgMasters.Mordor.Izek.API.Mapper;
using ProgMasters.Mordor.Izek.Service.Abstractions;

namespace ProgMasters.Mordor.Izek.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrkController : ControllerBase
    {
        private readonly IOrkService orkService;
        private readonly IOrkMapper orkMapper;

        public OrkController(IOrkService orkService, IOrkMapper orkMapper)
        {
            this.orkService = orkService;
            this.orkMapper = orkMapper;
        }

        [HttpGet]
        public IEnumerable<Ork> Get()
        {
            var orks = orkService.GetAll();
            return orks.Select(o => orkMapper.MapToDto(o));
        }
    }
}
