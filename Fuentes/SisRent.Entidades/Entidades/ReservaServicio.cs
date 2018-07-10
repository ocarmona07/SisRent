namespace SisRent.Entidades.Entidades
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ReservaServicio")]
    public partial class ReservaServicio
    {
        [Key]
        public int IdReservaServicio { get; set; }

        public int IdReserva { get; set; }

        public int IdServicio { get; set; }

        public decimal ValorServicio { get; set; }

        public virtual Reservas Reservas { get; set; }

        public virtual Servicios Servicios { get; set; }
    }
}
