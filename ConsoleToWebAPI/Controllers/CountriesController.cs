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

        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute] int id, [FromHeader] string developer) 
        {
            return Ok($"Name={developer}");

        }

        [HttpGet("search")]

        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))] string [] countries)
        {
            return Ok(countries);
        }

        [HttpGet("{id}")]

        public IActionResult CountryDetails([ModelBinder(Name ="Id")] CountryModel country)
        {
            return Ok(country);
        }




    }
}
