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
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Population { get; set; }

        [BindProperty]
        public int Area { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name={this.Name}, Population={this.Population}, Area={this.Area}");
        }
    }
}
