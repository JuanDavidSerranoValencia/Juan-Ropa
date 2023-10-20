using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            
            builder.ToTable("prenda");

            builder.HasIndex(p=>p.IdPrenda)
            .IsUnique();
          

            builder.Property(p=>p.NombrePrenda)
            .IsRequired()
            .HasMaxLength(50);
        
              builder.Property(p=>p.ValorUnitCop)
            .IsRequired()
            .HasColumnType("int");

             builder.Property(p=>p.ValorUnitUsd)
            .IsRequired()
            .HasColumnType("int");
    }
}
}