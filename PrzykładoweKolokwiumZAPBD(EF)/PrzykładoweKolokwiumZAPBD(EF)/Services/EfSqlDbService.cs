using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs;
using PrzykładoweKolokwiumZAPBD_EF_.Models;

namespace PrzykładoweKolokwiumZAPBD_EF_.Services
{
    public class EfSqlDbService : IDbService
    {

        private readonly BakeryDBContext _context;


        public EfSqlDbService(BakeryDBContext context)
        {
            _context = context;
        }


        public IEnumerable<Zamowienie> GetListZamowien()
        {
              return _context.Zamowienies.Include(x=>x.ZamowienieWyrobCukierniczies).ThenInclude(x=>x.WyrobCukierniczy);
            //  return _context.Zamowienies.Include(x => x.Klient).Include(x=>x.ZamowienieWyrobCukierniczies).ThenInclude(x=>x.WyrobCukierniczy);

        }

        public HelperRequest GetKlientZamowien(string nazwisko)
        {
            var helper = new HelperRequest();
            helper.Number = 0;

            var countKlient = _context.Klients.Count(x=>x.Nazwisko ==nazwisko);

            if (countKlient == 0)
            {
                helper.Number = 1;
                return helper;
            }


            var countKlientZamowienia = _context.Zamowienies.Count(x => x.Klient.Nazwisko == nazwisko);

            if (countKlientZamowienia == 0)
            {
                helper.Number = 2;
                return helper;
            }



            //if(_context.Zamowienies.Where(x=> x.Klient.Nazwisko))
            helper.List = _context.Zamowienies.Where(x => x.Klient.Nazwisko == nazwisko).Include(z => z.ZamowienieWyrobCukierniczies).ThenInclude(x => x.WyrobCukierniczy).ToList();
            return helper;
        }
    }
}
