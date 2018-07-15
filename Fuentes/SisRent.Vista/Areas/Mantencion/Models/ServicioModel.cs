namespace SisRent.Vista.Areas.Mantencion.Models
{
    public class ServicioModel
    {
        public int IdServicio { get; set; }
        public string Servicio { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public bool Estado { get; set; }
    }
}