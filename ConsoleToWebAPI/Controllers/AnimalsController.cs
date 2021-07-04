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

        private List<AnimalModel> animals = null;
        public AnimalsController()
        {
           animals = new List<AnimalModel>()
            {
                new AnimalModel(){ Id=1, Name="Cat" },
                new AnimalModel(){ Id=2, Name="Dog" }
            };
        }
       



        [Route("", Name ="All")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return AcceptedAtRoute("All");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
       
            return Ok(animals);
        }

    }
}
