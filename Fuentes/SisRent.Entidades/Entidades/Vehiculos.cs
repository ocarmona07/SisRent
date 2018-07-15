namespace SisRent.Entidades.Entidades
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Vehiculos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculos()
        {
            Reservas = new HashSet<Reservas>();
        }

        [Key]
        public int IdVehiculo { get; set; }

        public int? IdModelo { get; set; }

        public int Anio { get; set; }

        [Required]
        [StringLength(7)]
        public string Patente { get; set; }

        [StringLength(256)]
        public string RutaImagen { get; set; }

        [Required]
        public string Detalles { get; set; }

        public decimal Valor { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservas> Reservas { get; set; }

        public virtual VehModelos VehModelos { get; set; }
    }
}
