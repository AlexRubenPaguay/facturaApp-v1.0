using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FACTURA_TEST1.Models
{
    public partial class DbContextVentas : DbContext
    {
        public DbContextVentas()
            : base("name=DbContextVentas")
        {
        }

        public virtual DbSet<Detalle_Factura> Detalle_Factura { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Parametro> Parametro { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detalle_Factura>()
                .Property(e => e.Cantidad)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Detalle_Factura>()
                .Property(e => e.PrecioUnitario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Detalle_Factura>()
                .Property(e => e.Subtotal)
                .HasPrecision(21, 4);

            modelBuilder.Entity<Factura>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.BaseIVA0)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Factura>()
                .Property(e => e.BaseIVA12)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Factura>()
                .Property(e => e.IVA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Factura>()
                .HasMany(e => e.Detalle_Factura)
                .WithRequired(e => e.Factura)
                .HasForeignKey(e => e.cod_factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parametro>()
                .Property(e => e.codigo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Parametro>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Parametro>()
                .Property(e => e.valor)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Detalle_Factura)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => e.cod_producto)
                .WillCascadeOnDelete(false);
        }
    }
}
