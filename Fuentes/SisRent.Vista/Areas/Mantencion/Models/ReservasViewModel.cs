namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System.Collections.Generic;
    using Vista.Models;

    public class ReservasViewModel
    {
        public List<ReservaModel> ListaReservas { get; set; }
        public List<ComboModel> ListaComunas { get; set; }
        public List<ServicioModel> ListaServicios { get; set; }
        public List<VehiculoModel> ListaVehiculos { get; set; }
    }
}