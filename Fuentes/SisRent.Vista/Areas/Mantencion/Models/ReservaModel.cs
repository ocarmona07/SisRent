namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System;
    using System.Collections.Generic;

    public class ReservaModel
    {
        public int IdReserva { get; set; }
        public int IdComunaRetiro { get; set; }
        public string ComunaRetiro { get; set; }
        public DateTime FechaHoraRetiro { get; set; }
        public string FechaRetiro { get; set; }
        public string HoraRetiro { get; set; }
        public int? IdComunaEntrega { get; set; }
        public string ComunaEntrega { get; set; }
        public DateTime FechaHoraEntrega { get; set; }
        public string FechaEntrega { get; set; }
        public string HoraEntrega { get; set; }
        public int IdVehiculo { get; set; }
        public VehiculoModel Vehiculo { get; set; }
        public List<ServicioModel> Servicios { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int? IdComuna { get; set; }
        public string Comuna { get; set; }
        public string Telefono { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public decimal ValorFinal { get; set; }
        public int IdUsuario { get; set; }
        public UsuarioModel Usuario { get; set; }
        public string Observaciones { get; set; }
    }
}