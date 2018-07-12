namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System.Collections.Generic;

    public class VehiculosViewModel
    {
        public List<VehiculoModel> ListaVehiculos { get; set; }
        public List<ComboModel> ListaMarcas { get; set; }
    }
}