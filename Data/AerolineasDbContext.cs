using Aerolineas.Models;
using Microsoft.EntityFrameworkCore;

namespace Aerolineas.Data
{
    public class AerolineasDbContext : DbContext
    {
        public AerolineasDbContext(DbContextOptions<AerolineasDbContext> options)
        : base(options)
        {
        }

        public DbSet<Pasajeros> Pasajero { get; set; }
        public DbSet<Vuelos> Vuelo { get; set; }
        public DbSet<Reservas> Reserva { get; set; }
        public DbSet<Aerolinea> Aerolineas { get; set; }
        public DbSet<Itinerarios> Itinerario { get; set; }
    }
}
