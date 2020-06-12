using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrzykładoweKolokwiumZAPBD_EF_.DTOs.Requests
{
    public class WyrobyRequest
    {

        public string Uwagi { get; set; }

        [Required]
        public int Ilosc { get; set; }

        [Required]
        public string Wyrob { get; set; }
    }
}
