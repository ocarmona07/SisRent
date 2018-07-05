namespace SisRent.Entidades.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservaServicio")]
    public partial class ReservaServicio
    {
        [Key]
        public int IdReservaServicio { get; set; }

        public int? IdReserva { get; set; }

        public int? IdServicio { get; set; }

        public virtual Reservas Reservas { get; set; }

        public virtual Servicios Servicios { get; set; }
    }
}
