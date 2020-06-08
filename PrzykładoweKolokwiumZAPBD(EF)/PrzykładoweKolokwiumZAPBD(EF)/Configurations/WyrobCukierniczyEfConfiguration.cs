using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrzykładoweKolokwiumZAPBD_EF_.Models;

namespace PrzykładoweKolokwiumZAPBD_EF_.Configurations
{
    public class WyrobCukierniczyEfConfiguration : IEntityTypeConfiguration<WyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<WyrobCukierniczy> builder)
        {
            builder.HasKey(key => key.IdWyrobCukierniczy);
            builder.Property(e => e.Nazwa).HasMaxLength(200).IsRequired();
            builder.Property(e => e.CenaZaSzt).IsRequired();
            builder.Property(e => e.Typ).HasMaxLength(40).IsRequired();
        }
    }
}
