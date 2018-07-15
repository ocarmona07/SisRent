namespace SisRent.Entidades.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Reservas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservas()
        {
            ReservaServicio = new HashSet<ReservaServicio>();
        }

        [Key]
        public int IdReserva { get; set; }

        public int IdComunaRetiro { get; set; }

        public DateTime FechaRetiro { get; set; }

        public int? IdComunaEntrega { get; set; }

        public DateTime? FechaEntrega { get; set; }

        public int IdVehiculo { get; set; }

        [Required]
        [StringLength(32)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(32)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(64)]
        public string Email { get; set; }

        [Required]
        [StringLength(128)]
        public string Direccion { get; set; }

        public int? IdComuna { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefono { get; set; }

        public int IdEstado { get; set; }

        public decimal ValorFinal { get; set; }

        public int IdUsuario { get; set; }

        public string Observaciones { get; set; }

        public virtual Comunas Comunas { get; set; }

        public virtual Comunas Comunas1 { get; set; }

        public virtual Comunas Comunas2 { get; set; }

        public virtual Estados Estados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaServicio> ReservaServicio { get; set; }

        public virtual Usuarios Usuarios { get; set; }

        public virtual Vehiculos Vehiculos { get; set; }
    }
}
