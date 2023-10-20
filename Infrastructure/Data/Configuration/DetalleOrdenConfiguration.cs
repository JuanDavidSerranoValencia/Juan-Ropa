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
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("datelleorden");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.CantidadProducir)
            .HasColumnType("int")
            .HasMaxLength(50);

            builder.Property(p => p.CantidadProducir)
            .HasColumnType("int")
            .HasMaxLength(50);

            builder.HasOne(p => p.Orden)
            .WithMany(p => p.DatallesOrdens)
            .HasForeignKey(p => p.IdOrdenFk);


            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.DatallesOrdens)
            .HasForeignKey(p => p.IdPrendaFk);


            builder.HasOne(p => p.Estado)
            .WithMany(p => p.DatallesOrdens)
            .HasForeignKey(p => p.IdEstadoFk);

        }
    }
}