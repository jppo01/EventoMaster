using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventoMaster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EventoMaster.API.Data
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options) {  }  
        public DbSet<Evento> Eventos { get; set; }
        
        
    }
}