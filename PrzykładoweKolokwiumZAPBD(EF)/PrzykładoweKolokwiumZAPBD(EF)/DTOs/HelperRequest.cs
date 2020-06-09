using PrzykładoweKolokwiumZAPBD_EF_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzykładoweKolokwiumZAPBD_EF_.DTOs
{
    public class HelperRequest
    {
        public int Number { get; set; }

        public IEnumerable<Zamowienie> List {get;set;}
    }
}
