using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
             builder.ToTable("inventariotalla");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);


            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.InventariosTallas)
            .HasForeignKey(p => p.IdInventarioFk);

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.InventariosTallas)
            .HasForeignKey(p => p.IdTallaFk);
        }
    }
}