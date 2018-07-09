namespace SisRent.Negocio.Admin
{
    using Datos.Admin;
    using Entidades.Request;
    using Entidades.Response;

    public class VehiculosBo
    {
        public VehiculosResponse AgregaVehiculo(VehiculosRequest request)
        {
            return new VehiculosDa().CrearVehiculo(request);
        }

        public VehiculosResponse ObtenerVehiculos()
        {
            return new VehiculosDa().ObtenerVehiculos();
        }

        public VehiculosResponse ObtenerVehiculo(VehiculosRequest request)
        {
            return new VehiculosDa().ObtenerVehiculo(request);
        }

        public VehiculosResponse ActualizarVehiculo(VehiculosRequest request)
        {
            return new VehiculosDa().ActualizarVehiculo(request);
        }

        public VehiculosResponse EliminarVehiculo(VehiculosRequest request)
        {
            return new VehiculosDa().EliminarVehiculo(request);
        }
    }
}
