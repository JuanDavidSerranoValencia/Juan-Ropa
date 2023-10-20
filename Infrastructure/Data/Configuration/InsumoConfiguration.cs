using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
              builder.ToTable("insumo");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.HasIndex(p => p.NombreInsumo).IsUnique();

            builder.Property(p=>p.ValorUnit)
            .HasColumnType("int");

              builder.Property(p=>p.StockMin)
            .HasColumnType("int");

              builder.Property(p=>p.StockMax)
            .HasColumnType("int");
        }
    }
}