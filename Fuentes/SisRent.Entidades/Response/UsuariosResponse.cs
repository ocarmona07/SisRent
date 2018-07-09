namespace SisRent.Entidades.Response
{
    using System.Collections.Generic;
    using Common;
    using Entidades;

    public class UsuariosResponse : ResponseBase
    {
        public Usuarios Usuario { get; set; }
        public List<Usuarios> Usuarios { get; set; }
    }
}
