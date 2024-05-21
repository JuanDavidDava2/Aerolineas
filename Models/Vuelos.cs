namespace Aerolineas.Models
{
    public class Vuelos
    {
        public int IdVuelo { get; set; }
        public string NumeroVuelo { get; set; }
        public int IdAerolinea { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public decimal Precio { get; set; }

        public Aerolinea Aerolinea { get; set; }
        public ICollection<Reservas> Reservas { get; set; }
    }

}
