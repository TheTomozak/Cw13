using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrzykładoweKolokwiumZAPBD_EF_.Models;

namespace PrzykładoweKolokwiumZAPBD_EF_.Configurations
{
    public class KlientEfConfiguration : IEntityTypeConfiguration<Klient>
    {
        public void Configure(EntityTypeBuilder<Klient> builder)
        {
            builder.HasKey(key => key.IdKlient);
            builder.Property(e => e.Imie).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Nazwisko).HasMaxLength(60).IsRequired();
        }
    }
}
