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
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.HasIndex(p => p.Nit)
            .IsUnique();
             
            builder.Property(p => p.RazonSocial)
            .IsRequired()
            .HasMaxLength(100);

             builder.Property(p => p.RepresentanteLegal)
            .IsRequired()
            .HasMaxLength(100);

             builder.Property(p=>p.FechaCreacion)
            .HasColumnType("datetime");


            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Emspresas)
            .HasForeignKey(p => p.IdMunicipioFk);

            
       
        }
    }
}