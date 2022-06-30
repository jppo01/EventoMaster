using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventoMaster.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EventoMaster.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[]
            {   
                new Evento()
                {
                    EventoId = 1,
                    Tema = "angular",
             }
            };
        }
    }
}
