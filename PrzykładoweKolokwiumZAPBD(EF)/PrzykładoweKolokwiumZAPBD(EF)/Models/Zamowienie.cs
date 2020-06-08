using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzykładoweKolokwiumZAPBD_EF_.Models
{
    public class Zamowienie
    {
        public Zamowienie()
        {
            ZamowienieWyrobCukierniczies = new HashSet<ZamowienieWyrobCukierniczy>();
        }


        public int IdZamowienie { get; set; }

        public DateTime DataPrzyjecia { get; set; }
        public DateTime DataRealizacji { get; set; }
        public string Uwagi { get; set; }

        public int IdKlient { get; set; }
        public int IdPracownik { get; set; }

        public virtual Klient Klient { get; set; }
        public virtual Pracownik Pracownik { get; set; }

        public virtual ICollection<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczies { get; set; }
    }
}