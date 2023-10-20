using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("inventario");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.HasIndex(p => p.CodInventario)
            .IsUnique();

            builder.Property(p=>p.IdPrenda)
            .HasColumnType("int");

              builder.Property(p=>p.ValorVtaCop)
            .HasColumnType("int");
            
              builder.Property(p=>p.ValorVtaUsd)
            .HasColumnType("int");
        }
    }
}