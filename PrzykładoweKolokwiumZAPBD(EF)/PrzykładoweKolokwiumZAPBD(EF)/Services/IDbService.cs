using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs.Requests;
using PrzykładoweKolokwiumZAPBD_EF_.Models;

namespace PrzykładoweKolokwiumZAPBD_EF_.Services
{
    public interface IDbService
    {

        public IEnumerable<Zamowienie> GetListZamowien();
        public HelperRequest GetKlientZamowien(string nazwisko);

        public HelperRequest AddNewZamowienie(AddNewZamowianieRequest request, int id);

    }
}
