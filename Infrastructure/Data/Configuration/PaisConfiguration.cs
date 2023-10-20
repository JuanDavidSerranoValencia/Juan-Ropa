using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
             builder.ToTable("pais");

              builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

          builder.Property(p=>p.NomPais)
          .IsRequired()
          .HasMaxLength(50);
        }
    }
}