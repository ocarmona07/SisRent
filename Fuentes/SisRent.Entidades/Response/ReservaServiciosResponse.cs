namespace SisRent.Entidades.Response
{
    using System.Collections.Generic;
    using Common;
    using Entidades;

    public class ReservaServiciosResponse : ResponseBase
    {
        public ReservaServicio ReservaServicio { get; set; }
        public List<ReservaServicio> ReservaServicios { get; set; }
    }
}
