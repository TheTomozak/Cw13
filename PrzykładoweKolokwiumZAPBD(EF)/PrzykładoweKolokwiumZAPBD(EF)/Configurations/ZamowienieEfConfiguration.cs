using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrzykładoweKolokwiumZAPBD_EF_.Models;

namespace PrzykładoweKolokwiumZAPBD_EF_.Configurations
{
    public class ZamowienieEfConfiguration : IEntityTypeConfiguration<Zamowienie>
    {

        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder.HasKey(key => key.IdZamowienie);
            builder.Property(e => e.DataPrzyjecia).IsRequired();
            builder.Property(e => e.DataRealizacji).IsRequired();
            builder.Property(e => e.Uwagi).HasMaxLength(300);

            builder.HasOne(p => p.Pracownik).WithMany(z => z.Zamowienies).HasForeignKey(e => e.IdPracownik).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(p => p.Klient).WithMany(z => z.Zamowienies).HasForeignKey(e => e.IdKlient).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
