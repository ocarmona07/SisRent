namespace SisRent.Vista.Areas.Mantencion.Models
{
    public class InicioViewModel
    {
        public string Algo { get; set; }

        public HeaderViewModel Header { get; set; }
        public SidebarViewModel Sidebar { get; set; }
        public int Reservas { get; set; }
        public int Vehiculos { get; set; }
        public int Servicios { get; set; }
        public int Usuarios { get; set; }
    }
}