using Aerolineas.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Pasajeros> Pasajeros { get; set; }
    public DbSet<Vuelos> Vuelos { get; set; }
    public DbSet<Reservas> Reservas { get; set; }
    public DbSet<Aerolinea> Aerolineas { get; set; }
    public DbSet<Itinerarios> Itinerarios { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=SupermarketEF;Trusted_Connection=True;");
    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pasajeros>()
            .HasKey(p => p.IdPasajero);

        modelBuilder.Entity<Vuelos>()
            .HasKey(v => v.IdVuelo);

        modelBuilder.Entity<Aerolinea>()
            .HasKey(a => a.IdAerolinea);

        modelBuilder.Entity<Reservas>()
            .HasKey(r => r.IdReserva);

        modelBuilder.Entity<Itinerarios>()
            .HasKey(i => i.IdItinerario);

        modelBuilder.Entity<Pasajeros>()
            .HasMany(p => p.Reserva)
            .WithOne(r => r.Pasajero)
            .HasForeignKey(r => r.IdPasajero);

        modelBuilder.Entity<Vuelos>()
            .HasMany(v => v.Reservas)
            .WithOne(r => r.Vuelo)
            .HasForeignKey(r => r.IdVuelo);

        modelBuilder.Entity<Aerolinea>()
            .HasMany(a => a.Vuelo)
            .WithOne(v => v.Aerolinea)
            .HasForeignKey(v => v.IdAerolinea);

        modelBuilder.Entity<Reservas>()
            .HasMany(r => r.Itinerarios)
            .WithOne(i => i.Reserva)
            .HasForeignKey(i => i.IdReserva);
    }
}

