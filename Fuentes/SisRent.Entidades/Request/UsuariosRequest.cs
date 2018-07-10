namespace SisRent.Entidades.Request
{
    using Entidades;

    public class UsuariosRequest
    {
        public int IdUsuario { get; set; }
        public string RutUsuario { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
