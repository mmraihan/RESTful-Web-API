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
    public class BooksController : ControllerBase
    {
        /*  [Route("{id:int:min(10)}")]*/ // Route constraint add min ()

        [Route("{id:int:min(10):max(100)}")] //Route constraint add min() max()
        public string GetById(int id)
        {
            return "Hello int " + id;
        }

        [Route("{id}")] // by default string
        public string GetByString(string id)
        {
            return "Hello String " + id;
        }
    }
}
