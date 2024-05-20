namespace Aerolineas.Models
{
    public class Reservas
    {
        public int Id { get; set; } // PK
        public int PasajeroId { get; set; } // FK
        public int VueloId { get; set; } // FK
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; } // Confirmada, Cancelada
    }
}
