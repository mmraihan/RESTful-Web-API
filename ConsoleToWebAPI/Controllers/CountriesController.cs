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

        [HttpGet("{name}/{area}")] // passing data only with value  
        public IActionResult AddCountry( string name,int area) // passing data into query string
        {
            return Ok($"Name={name},");

        }
    }
}
