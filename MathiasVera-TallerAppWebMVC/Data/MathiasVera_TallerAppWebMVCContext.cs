using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MathiasVera_TallerAppWebMVC.Models;

namespace MathiasVera_TallerAppWebMVC.Data
{
    public class MathiasVera_TallerAppWebMVCContext : DbContext
    {
        public MathiasVera_TallerAppWebMVCContext (DbContextOptions<MathiasVera_TallerAppWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MathiasVera_TallerAppWebMVC.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<MathiasVera_TallerAppWebMVC.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<MathiasVera_TallerAppWebMVC.Models.Estadio> Estadio { get; set; } = default!;
    }
}
