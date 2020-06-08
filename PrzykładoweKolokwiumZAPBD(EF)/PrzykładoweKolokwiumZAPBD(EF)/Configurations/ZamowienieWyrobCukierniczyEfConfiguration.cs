using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrzykładoweKolokwiumZAPBD_EF_.Models;

namespace PrzykładoweKolokwiumZAPBD_EF_.Configurations
{
    public class ZamowienieWyrobCukierniczyEfConfiguration : IEntityTypeConfiguration<ZamowienieWyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<ZamowienieWyrobCukierniczy> builder)
        {
            builder.HasKey(key => new { key.IdZamowienia, key.IdwyrobuCukierniczego });

            builder.HasOne(e => e.WyrobCukierniczy).WithMany(p => p.ZamowienieWyrobCukierniczies)
                .HasForeignKey(e => e.IdwyrobuCukierniczego).OnDelete(DeleteBehavior.ClientSetNull); 

            builder.HasOne(e => e.Zamowienie).WithMany(p => p.ZamowienieWyrobCukierniczies)
                .HasForeignKey(e => e.IdZamowienia).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Property(e => e.Ilosc).IsRequired();
            builder.Property(e => e.Uwagi).HasMaxLength(300);

            builder.ToTable("Zamowienie_WyrobCukierniczy");
        }
    }
}
