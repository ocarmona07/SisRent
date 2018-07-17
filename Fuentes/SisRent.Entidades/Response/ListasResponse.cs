namespace SisRent.Entidades.Response
{
    using System.Collections.Generic;
    using Common;
    using Entidades;

    public class ListasResponse : ResponseBase
    {
        public List<Roles> Roles { get; set; }
        public List<RolAcceso> RolAccesos { get; set; }
        public List<Accesos> Accesos { get; set; }
        public List<Comunas> Comunas { get; set; }
        public List<VehMarcas> Marcas { get; set; }
        public List<VehModelos> Modelos { get; set; }
        public List<Estados> Estados { get; set; }
        public List<ReservaServicio> ReservaServicios { get; set; }

        public int Reservas { get; set; }
        public int Vehiculos { get; set; }
        public int Servicios { get; set; }
        public int Usuarios { get; set; }
        public Dictionary<string, string> Lista { get; set; }
    }
}
