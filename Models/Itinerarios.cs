namespace Aerolineas.Models
{
    public class Itinerarios
    {
        public int Id { get; set; } // PK
        public int IdReserva { get; set; } // FK
        public string Detalle { get; set; }
    }
}
