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
    [BindProperties]
    public class CountriesController : ControllerBase
    {

        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }

        [HttpPost("")]

        public IActionResult AddCountry()
        {
            return Ok($"Name={this.Name}," +
                $" Population={this.Population}," +
                $" Area={this.Area}");
        }
    }
}
