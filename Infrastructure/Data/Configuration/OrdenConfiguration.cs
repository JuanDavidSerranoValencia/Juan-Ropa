using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
           builder.ToTable("orden");

              builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.FechaOrden)
            .HasColumnType("datetime");

            builder.HasOne(p=>p.Empleado)
            .WithMany(p=>p.Ordens)
            .HasForeignKey(p=>p.IdEmpleadoFk);

             builder.HasOne(p=>p.Cliente)
            .WithMany(p=>p.Ordens)
            .HasForeignKey(p=>p.IdClienteFk);

             builder.HasOne(p=>p.Estado)
            .WithMany(p=>p.Ordens)
            .HasForeignKey(p=>p.IdEstadoFk);
        }
    }
}