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
    public class EmployeeController : ControllerBase
    {
        //public string GetEmployees()
        //{
        //    return "GetEmployeee works";
        //}

        public EmployeeModel GetEmployees() // Return Non-primitive types
        {
            return new EmployeeModel()
            {
                Id = 1,
                Name = "Raihan"
            };
        }

    }
}
