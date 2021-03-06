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




        [Route("", Name = "All")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
           /* return LocalRedirect("~/api/animals")*/;  //Loacl direct 302
            return LocalRedirectPermanent("~/api/animals");  //Loacl direct Permanent 301

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

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }
            var animal = animals.FirstOrDefault(x => x.Id == id);

            if (animal==null)
            {
                return NotFound();
            }

            return Ok(animals);
        }


        [HttpPost("")]
        public IActionResult GetaAnimals( AnimalModel animal)
        {
            animals.Add(animal);
            return Created("~/api/animals/" +animal.Id, animal);
        }



    }
}
