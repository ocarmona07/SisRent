namespace SisRent.Negocio.Admin
{
    using Datos.Admin;
    using Entidades.Request;
    using Entidades.Response;

    public class UsuariosBo
    {
        public UsuariosResponse AgregaUsuario(UsuariosRequest request)
        {
            return new UsuariosDa().CrearUsuario(request);
        }

        public UsuariosResponse ObtenerUsuarios()
        {
            return new UsuariosDa().ObtenerUsuarios();
        }

        public UsuariosResponse ObtenerUsuario(UsuariosRequest request)
        {
            return new UsuariosDa().ObtenerUsuario(request);
        }

        public UsuariosResponse ActualizarUsuario(UsuariosRequest request)
        {
            return new UsuariosDa().ActualizarUsuario(request);
        }

        public UsuariosResponse EliminarUsuario(UsuariosRequest request)
        {
            return new UsuariosDa().EliminarUsuario(request);
        }
    }
}
