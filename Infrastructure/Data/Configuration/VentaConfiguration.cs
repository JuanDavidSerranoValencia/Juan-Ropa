using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("venta");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.Fecha)
          .HasColumnType("datetime");

          builder.HasOne(p=>p.Empleado)
          .WithMany(p=>p.Venstas)
          .HasForeignKey(p=>p.IdEmpleadoFk);

            builder.HasOne(p=>p.Cliente)
          .WithMany(p=>p.Venstas)
          .HasForeignKey(p=>p.IdClienteFk);

            builder.HasOne(p=>p.FormaPago)
          .WithMany(p=>p.Venstas)
          .HasForeignKey(p=>p.IdFormaPagoFk);


        }
    }
}