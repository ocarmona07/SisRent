namespace SisRent.Entidades.Entidades
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RolAcceso")]
    public partial class RolAcceso
    {
        [Key]
        public int IdRolAcceso { get; set; }

        public int? IdRol { get; set; }

        public int? IdAcceso { get; set; }

        public virtual Accesos Accesos { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
