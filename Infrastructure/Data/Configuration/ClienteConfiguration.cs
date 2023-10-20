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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
              builder.ToTable("cliente");

            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Id);

            builder.HasIndex(p=>p.IdCliente)
            .IsUnique();
            
            builder.Property(p=>p.NombreCliente)
            .IsRequired()
            .HasMaxLength(50);

          
            builder.Property(p=>p.FechaRegistro)
            .HasColumnType("datetime");

            builder.HasOne(p=>p.TipoPersona)
            .WithMany(p=>p.Clienstes)
            .HasForeignKey(p=>p.IdTipoPersonaFk);

            builder.HasOne(p=>p.Municipio)
            .WithMany(p=>p.Clienstes)
            .HasForeignKey(p=>p.IdMunicipioFk);
        }
    }
}