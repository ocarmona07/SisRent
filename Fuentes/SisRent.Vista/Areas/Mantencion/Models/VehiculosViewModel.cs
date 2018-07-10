namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System.Collections.Generic;
    using Entidades.Entidades;

    public class VehiculosViewModel
    {
        public List<Vehiculos> ListaVehiculos { get; set; }
        public List<VehMarcas> ListaMarcas { get; set; }
    }
}