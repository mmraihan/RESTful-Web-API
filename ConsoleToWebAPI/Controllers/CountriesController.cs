using ConsoleToWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class CountriesController : ControllerBase
    {
        //public CountryModel Country { get; set; }

        [HttpPost("")] 
        public IActionResult AddCountry([FromQuery] CountryModel country) 
        {
            return Ok($"Name={country.Name},");

        }
    }
}
