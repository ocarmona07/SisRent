namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System.Collections.Generic;
    
    public class HeaderViewModel
    {
        public Dictionary<string, string> Notificaciones { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompletoUsuario { get; set; }
        public string ImagenUsuario { get; set; }
        public string Rol { get; set; }
    }
}