namespace SisRent.Entidades.Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SisRentModel : DbContext
    {
        public SisRentModel()
            : base("name=SisRentEntityModel")
        {
        }

        public virtual DbSet<Accesos> Accesos { get; set; }
        public virtual DbSet<Comunas> Comunas { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<ReservaServicio> ReservaServicio { get; set; }
        public virtual DbSet<RolAcceso> RolAcceso { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<VehMarcas> VehMarcas { get; set; }
        public virtual DbSet<VehModelos> VehModelos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comunas>()
                .HasMany(e => e.Reservas)
                .WithRequired(e => e.Comunas)
                .HasForeignKey(e => e.IdComunaRetiro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comunas>()
                .HasMany(e => e.Reservas1)
                .WithOptional(e => e.Comunas1)
                .HasForeignKey(e => e.IdComunaEntrega);

            modelBuilder.Entity<Comunas>()
                .HasMany(e => e.Reservas2)
                .WithOptional(e => e.Comunas2)
                .HasForeignKey(e => e.IdComuna);

            modelBuilder.Entity<Servicios>()
                .Property(e => e.Valor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Vehiculos>()
                .Property(e => e.Valor)
                .HasPrecision(18, 0);
        }
    }
}
