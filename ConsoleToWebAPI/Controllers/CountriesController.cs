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

        [HttpGet("{Name}")] 
        public IActionResult AddCountry([FromQuery] string name) 
        {
            return Ok($"Name={name},");

        }
    }
}
