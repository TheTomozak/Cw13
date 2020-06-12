using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs.Requests;
using PrzykładoweKolokwiumZAPBD_EF_.Models;
using PrzykładoweKolokwiumZAPBD_EF_.Services;

namespace PrzykładoweKolokwiumZAPBD_EF_.Controllers
{
    [Route("api")]
    [ApiController]
    public class BakeryController : ControllerBase
    {

        private readonly IDbService _context;


        public BakeryController(IDbService context)
        {
            _context = context;
        }

        
        [HttpGet("orders")]
        public IActionResult GetList()
        {
            return Ok( _context.GetListZamowien() );
        }


        [HttpGet("orders/{nazwisko}")]
        public IActionResult GetKlient(string nazwisko)
        {

            HelperRequest helperRequest = _context.GetKlientZamowien(nazwisko);


            switch (helperRequest.Number)
            {
                case 1:
                    return BadRequest($"Klient o nazwisku \"{nazwisko}\" nie istnieje");
                case 2:
                    return BadRequest($"Klient \"{nazwisko}\" nie posiada zamowien");
                default:
                    return Ok(helperRequest.List);
            }

          
        }

        [HttpPost("clients/{id}/orders")]
        public IActionResult CreateZamowienie(AddNewZamowianieRequest request, int id)
        {
            HelperRequest helperRequest = _context.AddNewZamowienie(request, id);


            switch (helperRequest.Number)
            {
                case 1:
                    return BadRequest($"Brak klienta o id: \"{id}\" ");
                    
                case 2:
                    return BadRequest($"Wyrob nie istnieje w bazie danych");
                    
                default:
                    return Ok("Dodano zamowienie!");
            };


        }


    }
}