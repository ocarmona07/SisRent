namespace SisRent.Entidades.Response
{
    using System.Collections.Generic;
    using Common;
    using Entidades;

    public class VehiculosResponse : ResponseBase
    {
        public Vehiculos Vehiculo { get; set; }
        public List<Vehiculos> Vehiculos { get; set; }
    }
}
