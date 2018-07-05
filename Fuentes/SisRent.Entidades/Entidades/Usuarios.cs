namespace SisRent.Entidades.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            Reservas = new HashSet<Reservas>();
        }

        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(12)]
        public string Rut { get; set; }

        [Required]
        [StringLength(32)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(32)]
        public string ApPaterno { get; set; }

        [StringLength(32)]
        public string ApMaterno { get; set; }

        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(64)]
        public string Email { get; set; }

        public int? IdRol { get; set; }

        [Required]
        [StringLength(16)]
        public string Clave { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservas> Reservas { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
