namespace SisRent.Negocio.Common
{
    using Datos.Common;
    using Entidades.Response;

    public class ListasBo
    {
        public ListasResponse ObtenerRoles()
        {
            return new ListasDa().ObtenerRoles();
        }

        public ListasResponse ObtenerRolAccesos()
        {
            return new ListasDa().ObtenerRolAccesos();
        }

        public ListasResponse ObtenerAccesos()
        {
            return new ListasDa().ObtenerAccesos();
        }

        public ListasResponse ObtenerComunas()
        {
            return new ListasDa().ObtenerComunas();
        }

        public ListasResponse ObtenerMarcas()
        {
            return new ListasDa().ObtenerMarcas();
        }

        public ListasResponse ObtenerModelos()
        {
            return new ListasDa().ObtenerModelos();
        }

        public ListasResponse ObtenerEstados()
        {
            return new ListasDa().ObtenerEstados();
        }
    }
}
