namespace Aerolineas.Models
{
    public class Reservas
    {
        public int IdReserva { get; set; }
        public int IdPasajero { get; set; }
        public int IdVuelo { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; }

        public Pasajeros Pasajero { get; set; }
        public Vuelos Vuelo { get; set; }
        public ICollection<Itinerarios> Itinerarios { get; set; }
    }

}
