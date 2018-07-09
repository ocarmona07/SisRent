namespace SisRent.Entidades.Response
{
    using System.Collections.Generic;
    using Common;
    using Entidades;

    public class ServiciosResponse : ResponseBase
    {
        public Servicios Servicio { get; set; }
        public List<Servicios> Servicios { get; set; }
    }
}
