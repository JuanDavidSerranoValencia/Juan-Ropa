using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class TallaConfiguration : IEntityTypeConfiguration<Talla>
    {
        public void Configure(EntityTypeBuilder<Talla> builder)
        {
             builder.ToTable("talla");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.HasIndex(p => p.Descripcion)
            .IsUnique();
            
        }
    }
}