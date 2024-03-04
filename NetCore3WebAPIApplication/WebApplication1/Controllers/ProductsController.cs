using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context)
        {
            _context = context;
            if (_context.Products.Count() == 0)
            {
                _context.Products.Add(new Product { Name = "Product 1" });
                _context.SaveChanges();
            }   

        }


        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if(product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }



    }
}
