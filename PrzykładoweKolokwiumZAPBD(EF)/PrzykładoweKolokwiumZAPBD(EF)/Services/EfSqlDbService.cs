using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs.Requests;
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

             return _context.Zamowienies.Include(x => x.Klient).Include(x=>x.Pracownik).Include(x=>x.ZamowienieWyrobCukierniczies).ThenInclude(x=>x.WyrobCukierniczy).ToList();

           
            //  return _context.Zamowienies.Include(x => x.Klient)|||Tu jakoś wjebać selecta żeby wwybrać pola bez klienta i pracowanika bo pokazue brzydko null|||.Include(x=>x.ZamowienieWyrobCukierniczies).ThenInclude(x=>x.WyrobCukierniczy).ToList();

            /*return _context.Zamowienies.Include(x => x.ZamowienieWyrobCukierniczies).Select(e=> new
            {
                e.IdZamowienie,
                e.DataPrzyjecia, 
                e.DataRealizacji, 
                e.Uwagi
            }).ThenInclude(x => x.WyrobCukierniczy).ToList();
            */


            



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

       

        public HelperRequest AddNewZamowienie(AddNewZamowianieRequest request, int id)
        {
            var helper = new HelperRequest();
            helper.Number = 0;


            var countIdKlienta = _context.Klients.Count(c => c.IdKlient == id);

            if(countIdKlienta == 0)
            {
                helper.Number = 1;
                return helper;
            }

            var countWyrob = _context.WyrobCukierniczies.Count(c => c.Nazwa == request.Wyrob);

            if (countWyrob == 0)
            {
                helper.Number = 2;
                return helper;
            }


            /*
            int maxIdWyrobuCukierczniego = _context.WyrobCukierniczies.Max(m => m.IdWyrobCukierniczy);
            int maxIdZamowienia = _context.Zamowienies.Max(m => m.IdZamowienie);
             */



          

            var wyrob = new WyrobCukierniczy
            {
               
                Nazwa = request.Wyrob

            };

            var zamowienie = new Zamowienie
            {
               
                IdKlient = id,
                DataPrzyjecia = request.DataPrzyjecia,
                Uwagi = request.UwagiZamowienia,
               

            };

            var zamowienieWyrob = new ZamowienieWyrobCukierniczy
            {
               
                Ilosc = request.Ilosc,
                Uwagi = request.Uwagi,
                WyrobCukierniczy = wyrob,
                Zamowienie = zamowienie

            };


            

            _context.Attach(zamowienie);
            _context.Add(zamowienie);
            _context.SaveChangesAsync();


            return helper;        
        }
    }
}
