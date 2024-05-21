namespace Aerolineas.Models
{
    public class Itinerarios
    {
        public int IdItinerario { get; set; }
        public int IdReserva { get; set; }
        public string Detalle { get; set; }

        public Reservas Reserva { get; set; }
    }
}
