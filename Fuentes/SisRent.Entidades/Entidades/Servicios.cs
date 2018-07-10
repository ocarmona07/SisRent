namespace SisRent.Entidades.Entidades
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Servicios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicios()
        {
            ReservaServicio = new HashSet<ReservaServicio>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdServicio { get; set; }

        [Required]
        [StringLength(32)]
        public string Servicio { get; set; }

        [StringLength(64)]
        public string Descripcion { get; set; }

        public decimal Valor { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaServicio> ReservaServicio { get; set; }
    }
}
