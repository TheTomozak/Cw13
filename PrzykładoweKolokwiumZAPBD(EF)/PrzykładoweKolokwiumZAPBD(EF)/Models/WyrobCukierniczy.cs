using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzykładoweKolokwiumZAPBD_EF_.Models
{
    public class WyrobCukierniczy
    {
        public WyrobCukierniczy()
        {
            
            ZamowienieWyrobCukierniczies = new HashSet<ZamowienieWyrobCukierniczy>();
        }


        public int IdWyrobCukierniczy { get; set; }
        public string Nazwa { get; set; }
        public float CenaZaSzt { get; set; }
        public string Typ { get; set; }

        public virtual ICollection<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczies { get; set; }
       

    }
}
