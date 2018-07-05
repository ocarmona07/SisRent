namespace SisRent.Entidades.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

        public decimal Valor { get; set; }

        [Required]
        [StringLength(7)]
        public string Patente { get; set; }

        [Required]
        [StringLength(512)]
        public string Observaciones { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservas> Reservas { get; set; }

        public virtual VehModelos VehModelos { get; set; }
    }
}