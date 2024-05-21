namespace Aerolineas.Models
{
    public class Aerolinea
    {
        public int IdAerolinea { get; set; }
        public string? NombreAerolinea { get; set; }

        public ICollection<Vuelos> Vuelo { get; set; }
    }
}
