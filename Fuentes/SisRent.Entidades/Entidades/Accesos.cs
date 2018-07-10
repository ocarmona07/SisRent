namespace SisRent.Entidades.Entidades
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Accesos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accesos()
        {
            Accesos1 = new HashSet<Accesos>();
            RolAcceso = new HashSet<RolAcceso>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAcceso { get; set; }

        public int? IdAccesoPadre { get; set; }

        [Required]
        [StringLength(32)]
        public string Acceso { get; set; }

        [StringLength(64)]
        public string Descripcion { get; set; }

        [StringLength(24)]
        public string Icono { get; set; }

        [Required]
        [StringLength(128)]
        public string UrlAcceso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accesos> Accesos1 { get; set; }

        public virtual Accesos Accesos2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolAcceso> RolAcceso { get; set; }
    }
}
