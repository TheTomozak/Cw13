using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrzykładoweKolokwiumZAPBD_EF_.Configurations;

namespace PrzykładoweKolokwiumZAPBD_EF_.Models
{
    public class BakeryDBContext : DbContext
    {


      

        public BakeryDBContext(DbContextOptions options) : base(options)
        {
        }

        
        public DbSet<Zamowienie> Zamowienies { get; set; }
        public DbSet<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczies { get; set; }
        public DbSet<WyrobCukierniczy> WyrobCukierniczies { get; set; }
        public DbSet<Klient> Klients  { get; set; }
        public DbSet<Pracownik> Pracowniks  { get; set; }


        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new KlientEfConfiguration());
            modelBuilder.ApplyConfiguration(new PracownikEfConfiguration());
            modelBuilder.ApplyConfiguration(new WyrobCukierniczyEfConfiguration());
            modelBuilder.ApplyConfiguration(new ZamowienieEfConfiguration());
            modelBuilder.ApplyConfiguration(new ZamowienieWyrobCukierniczyEfConfiguration());

        }

    }
}
