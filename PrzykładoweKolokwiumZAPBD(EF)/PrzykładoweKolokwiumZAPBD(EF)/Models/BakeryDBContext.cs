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
