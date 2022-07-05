using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventoMaster.API.Data;
using EventoMaster.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EventosMaster.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        // Construtor
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
            
        }


        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }
    }
}
