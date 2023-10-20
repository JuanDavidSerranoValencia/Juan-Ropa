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
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("cargo");

            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Id);

            builder.Property(p=>p.Descripcion)
            .HasMaxLength(50);
            
            builder.Property(p=>p.SueldoBase)
            .HasColumnType("int");
        }
    }
}