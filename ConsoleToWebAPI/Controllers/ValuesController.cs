﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{

    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]
        public string GetAll()
        {
            return "Hello from GetAll()";
        }

        [Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "Hello from GetAllAuthors()";
        }
    }
}