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
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepositoy; // connecton between repository and controller

        public ProductController()
        {
            _productRepositoy = new ProductRepository();

        }

        [HttpPost("")]

        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productRepositoy.AddProduct(product);

            var products = _productRepositoy.GetAllProducts();
            return Ok(products);
        }

    }
}
