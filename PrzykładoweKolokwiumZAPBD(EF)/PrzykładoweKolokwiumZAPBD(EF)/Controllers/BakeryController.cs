using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrzykładoweKolokwiumZAPBD_EF_.DTOs;
using PrzykładoweKolokwiumZAPBD_EF_.Services;

namespace PrzykładoweKolokwiumZAPBD_EF_.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class BakeryController : ControllerBase
    {

        private readonly IDbService _context;


        public BakeryController(IDbService context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok( _context.GetListZamowien() );
        }


        [HttpGet("{nazwisko}")]
        public IActionResult GetKlient(string nazwisko)
        {

            HelperRequest helperRequest = _context.GetKlientZamowien(nazwisko);

            switch (helperRequest.Number)
            {
                case 1:
                    return BadRequest($"Klient o nazwisku \"{nazwisko}\" nie istnieje");
                    break;
                case 2:
                    return BadRequest($"Klient \"{nazwisko}\" nie posiada zamowien");
                    break;
                default:
                    return Ok(helperRequest.List);
            }

          
        }


    }
}