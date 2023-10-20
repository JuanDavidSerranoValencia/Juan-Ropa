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
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("empleado");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.HasIndex(p => p.IdEmpleado)
             .IsUnique();

            builder.Property(p => p.NombreEmpleado)
            .IsRequired()
            .HasMaxLength(100);

             builder.Property(p=>p.FechaIngreso)
            .HasColumnType("datetime");


            builder.HasOne(p => p.Cargo)
            .WithMany(p => p.Emplesados)
            .HasForeignKey(p => p.IdCargoFk);

            
            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Emplsados)
            .HasForeignKey(p => p.IdMunicipioFk);

           
         
        }
    }
}