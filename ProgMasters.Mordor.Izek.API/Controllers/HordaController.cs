using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgMasters.Mordor.Izek.API.Dto;
using ProgMasters.Mordor.Izek.Service.Abstractions;

namespace ProgMasters.Mordor.Izek.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HordaController : ControllerBase
    {

        private readonly ILogger<HordaController> _logger;
        private readonly IHordaService hordaService;

        public HordaController(ILogger<HordaController> logger, IHordaService hordaService)
        {
            _logger = logger;
            this.hordaService = hordaService;
        }

        [HttpGet]
        public IEnumerable<Horda> Get()
        {
            var hordak = hordaService.GetAll();

            return hordak.Select(domainHorda =>
            new Horda
            {
                Name = domainHorda.ToString()
            }).ToArray();
        }
    }
}
