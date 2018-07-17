namespace SisRent.Negocio.Admin
{
    using Datos.Admin;
    using Entidades.Request;
    using Entidades.Response;

    public class ReservaServiciosBo
    {
        public ReservaServiciosResponse AgregaReservaServicio(ReservaServiciosRequest request)
        {
            return new ReservaServiciosDa().CrearReservaServicio(request);
        }

        public ReservaServiciosResponse ObtenerReservaServicios()
        {
            return new ReservaServiciosDa().ObtenerReservaServicios();
        }

        public ReservaServiciosResponse ObtenerReservaServicio(ReservaServiciosRequest request)
        {
            return new ReservaServiciosDa().ObtenerReservaServicio(request);
        }

        public ReservaServiciosResponse ActualizarReservaServicio(ReservaServiciosRequest request)
        {
            return new ReservaServiciosDa().ActualizarReservaServicio(request);
        }

        public ReservaServiciosResponse EliminarReservaServicio(ReservaServiciosRequest request)
        {
            return new ReservaServiciosDa().EliminarReservaServicio(request);
        }
    }
}
