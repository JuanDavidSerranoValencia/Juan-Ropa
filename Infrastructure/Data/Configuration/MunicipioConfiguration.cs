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
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("municipio");

              builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.HasOne(p=>p.Departamento)
            .WithMany(p=>p.Muniscipios)
            .HasForeignKey(p=>p.IdDepartamentoFK);


        }
    }
}