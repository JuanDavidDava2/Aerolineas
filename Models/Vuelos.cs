namespace Aerolineas.Models
{
    public class Vuelos
    {
        public int Id { get; set; } // PK
        public string NumeroVuelo { get; set; }
        public int AerolineaId { get; set; } // FK
        public string OrigenDestino { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public decimal Precio { get; set; }
    }
}
