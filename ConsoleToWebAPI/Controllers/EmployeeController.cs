using ConsoleToWebAPI.Model;
using ConsoleToWebAPI.Repository;
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


        //public EmployeeModel GetEmployees() // Return Non-primitive types
        //{
        //    return new EmployeeModel()
        //    {
        //        Id = 1,
        //        Name = "Raihan"
        //    };
        //}
        [Route("")]
        public List<EmployeeModel> GetEmployee()
        {

            return new List<EmployeeModel>()
            {
                new EmployeeModel(){Id=1, Name="Employee1"},
                new EmployeeModel(){Id=1, Name="Employee2"},

            };
        }
        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id==0)
            {
                return NotFound("");
            }

            return Ok(new List<EmployeeModel>()
            {
                new EmployeeModel(){Id=1, Name="Employee1"},
                new EmployeeModel(){Id=2, Name="Employee2"}

            }
            );
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id) // ActionResult for specific type
        {
            if (id == 0)
            {
                return NotFound("");
            }

            return new EmployeeModel() { Id = 1, Name = "Employee1" };

            
        }


        [HttpGet("name")]

        public IActionResult GetName([FromServices] IProductRepository _productRepositoy)
        {
            var name = _productRepositoy.GetName();
            return Ok(name);
        }



    }
}
