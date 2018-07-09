namespace SisRent.Negocio.Admin
{
    using Datos.Admin;
    using Entidades.Request;
    using Entidades.Response;

    public class ServiciosBo
    {
        public ServiciosResponse AgregaServicio(ServiciosRequest request)
        {
            return new ServiciosDa().CrearServicio(request);
        }

        public ServiciosResponse ObtenerServicios()
        {
            return new ServiciosDa().ObtenerServicios();
        }

        public ServiciosResponse ObtenerServicio(ServiciosRequest request)
        {
            return new ServiciosDa().ObtenerServicio(request);
        }

        public ServiciosResponse ActualizarServicio(ServiciosRequest request)
        {
            return new ServiciosDa().ActualizarServicio(request);
        }

        public ServiciosResponse EliminarServicio(ServiciosRequest request)
        {
            return new ServiciosDa().EliminarServicio(request);
        }
    }
}
