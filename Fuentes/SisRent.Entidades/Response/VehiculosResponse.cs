using System.Collections.Generic;
using SisRent.Entidades.Common;
using SisRent.Entidades.Entidades;

namespace SisRent.Entidades.Response
{
    public class VehiculosResponse : ResponseBase
    {
        public Vehiculos Vehiculo { get; set; }
        public List<Vehiculos> Vehiculos { get; set; }
    }
}
