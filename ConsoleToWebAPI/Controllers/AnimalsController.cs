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
    public class AnimalsController : ControllerBase
    {
        public IActionResult GetAnimals()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel(){ Id=1, Name="Cat" },
                new AnimalModel(){ Id=2, Name="Dog" }
            };

            return Ok(animals);
        }
    }
}
