namespace SisRent.Vista.Areas.Mantencion.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string Rut { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string RutaImagen { get; set; }
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
    }
}