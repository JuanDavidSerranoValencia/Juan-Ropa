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
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("poveedor");

            builder.HasIndex(p=>p.NitProveedor).IsUnique();
           

            builder.Property(p=>p.NombreProveedor)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p=>p.TipoPersona)
            .WithMany(p=>p.Proveedors)
            .HasForeignKey(p=>p.IdTipoPersonaFk);

            builder.HasOne(p=>p.Municipio)
            .WithMany(p=>p.Proveedors)
            .HasForeignKey(p=>p.IdMunicipioFk);
       
        }
    }
}