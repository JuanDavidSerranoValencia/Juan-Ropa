using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
             builder.ToTable("insumoproveedor");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);


            builder.HasOne(p => p.Proveedor)
            .WithMany(p => p.InsumosProveedores)
            .HasForeignKey(p => p.IdProveedorFk);

            builder.HasOne(p => p.Insumo)
            .WithMany(p => p.InsumosProveedores)
            .HasForeignKey(p => p.IdInsumoFk);
        }
    }
}