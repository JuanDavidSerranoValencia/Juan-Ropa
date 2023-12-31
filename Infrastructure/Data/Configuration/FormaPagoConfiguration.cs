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
    public class FormaPagoConfiguration : IEntityTypeConfiguration<FormaPago>
    {
        public void Configure(EntityTypeBuilder<FormaPago> builder)
        {
              builder.ToTable("formapago");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasMaxLength(100);


        }
    }
}