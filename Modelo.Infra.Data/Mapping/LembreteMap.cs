using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class LembreteMap : IEntityTypeConfiguration<Lembrete>
    {
        public void Configure(EntityTypeBuilder<Lembrete> builder)
        {
            builder.ToTable("Lembrete");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Texto)
                .IsRequired()
                .HasColumnName("Texto_Lembrete");
        }
    }
}
