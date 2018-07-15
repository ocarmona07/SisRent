namespace SisRent.Vista.Models
{
    using System.Collections.Generic;
    using Areas.Mantencion.Models;

    public class RentarViewModel
    {
        public List<ComboModel> ListaComunas { get; set; }
        public List<ServicioModel> ListaServicios { get; set; }
        public List<VehiculoModel> ListaVehiculos { get; set; }
    }
}