using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleventa");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.Cantidad)
             .IsRequired()
             .HasColumnType("int");

            builder.Property(p => p.ValorUnit)
            .IsRequired()
            .HasColumnType("int");


            builder.HasOne(p => p.Venta)
            .WithMany(p => p.DetallesVentas)
            .HasForeignKey(p => p.IdVentaFk);

            builder.HasOne(p => p.Inventario)
          .WithMany(p => p.DetallesVentas)
          .HasForeignKey(p => p.IdInventarioFk);

            builder.HasOne(p => p.Talla)
         .WithMany(p => p.DetallesVentas)
         .HasForeignKey(p => p.IdTallaFk);

        }
    }
}