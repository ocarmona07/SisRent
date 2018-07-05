namespace SisRent.Entidades.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Accesos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accesos()
        {
            RolAcceso = new HashSet<RolAcceso>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAcceso { get; set; }

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
        public virtual ICollection<RolAcceso> RolAcceso { get; set; }
    }
}
