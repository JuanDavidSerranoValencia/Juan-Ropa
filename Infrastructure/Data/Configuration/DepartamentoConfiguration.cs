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
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
                builder.ToTable("departamento");

            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Id);
            
            builder.Property(p=>p.NombreDepartamento)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p=>p.Pais)
            .WithMany(p=>p.Deparstamentos)
            .HasForeignKey(p=>p.IdPaisFk);
        }
    }
}