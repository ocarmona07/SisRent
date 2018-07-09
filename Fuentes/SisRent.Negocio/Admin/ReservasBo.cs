namespace SisRent.Negocio.Admin
{
    using Datos.Admin;
    using Entidades.Request;
    using Entidades.Response;

    public class ReservasBo
    {
        public ReservasResponse AgregaReserva(ReservasRequest request)
        {
            return new ReservasDa().CrearReserva(request);
        }

        public ReservasResponse ObtenerReservas()
        {
            return new ReservasDa().ObtenerReservas();
        }

        public ReservasResponse ObtenerReserva(ReservasRequest request)
        {
            return new ReservasDa().ObtenerReserva(request);
        }

        public ReservasResponse ActualizarReserva(ReservasRequest request)
        {
            return new ReservasDa().ActualizarReserva(request);
        }

        public ReservasResponse EliminarReserva(ReservasRequest request)
        {
            return new ReservasDa().EliminarReserva(request);
        }
    }
}
