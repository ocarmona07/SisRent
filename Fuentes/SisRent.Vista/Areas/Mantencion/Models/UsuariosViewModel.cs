namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System.Collections.Generic;
    using Vista.Models;

    public class UsuariosViewModel
    {
        public List<UsuarioModel> ListaUsuarios { get; set; }
        public List<ComboModel> ListaRoles { get; set; }
    }
}