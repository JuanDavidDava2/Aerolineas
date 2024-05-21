namespace Aerolineas.Models
{
    public class Pasajeros
    {
        public int IdPasajero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public ICollection<Reservas> Reserva { get; set; }
    }
}
