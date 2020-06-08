using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzykładoweKolokwiumZAPBD_EF_.Models
{
    public class ZamowienieWyrobCukierniczy
    {
        public int IdwyrobuCukierniczego { get; set; }

        public int IdZamowienia { get; set; }
        public int Ilosc { get; set; }
        public string Uwagi { get; set; }


        public virtual WyrobCukierniczy WyrobCukierniczy { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}