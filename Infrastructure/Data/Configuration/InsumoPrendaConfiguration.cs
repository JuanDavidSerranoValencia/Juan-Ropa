using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("insumoprenda");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);


            builder.HasOne(p => p.Insumo)
            .WithMany(p => p.InsumosPrendas)
            .HasForeignKey(p => p.IdInsumoFk);

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.InsumosPrendas)
            .HasForeignKey(p => p.IdPrendaFk);
        }
    }
}