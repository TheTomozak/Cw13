using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzykładoweKolokwiumZAPBD_EF_.Models
{
    public class Pracownik
    {
        public Pracownik()
        {
            Zamowienies = new HashSet<Zamowienie>();
        }

        public int IdPracownik { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public virtual ICollection<Zamowienie> Zamowienies { get; set; }

    }
}
