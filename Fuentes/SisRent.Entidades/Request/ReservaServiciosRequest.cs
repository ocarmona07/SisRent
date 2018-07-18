namespace SisRent.Entidades.Request
{
    using Entidades;

    public class ReservaServiciosRequest
    {
        public int IdReservaServicio { get; set; }
        public int IdReserva { get; set; }
        public ReservaServicio ReservaServicio { get; set; }
    }
}
