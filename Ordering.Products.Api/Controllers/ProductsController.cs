using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ordering.products.api.Interfaces;
using ordering.products.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ordering.Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _Context;


        public ProductsController(IProductRepository Context)
        {
            _Context = Context;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _Context.GetProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return _Context.GetProductId(id);
        }

       
    }
}
