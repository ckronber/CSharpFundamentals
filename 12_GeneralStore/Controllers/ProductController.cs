using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _content = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> Post(Product product)
        {
            if(ModelState.IsValid)
            {
                _content.Products.Add(product);
                await _content.SaveChangesAsync();
                return Ok(); // 200 (ok) status
            }

            return BadRequest(ModelState);//400 Bad Request
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Product> products = await _content.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProductById([FromUri] int Id)
        {
            Product product = await _content.Products.FindAsync(Id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateProdcutId([FromUri] int Id,[FromBody] Product newProduct)
        {
            if (ModelState.IsValid)
            {
                Product oldProduct = await _content.Products.FindAsync(Id);

                if(oldProduct != null)
                {
                    oldProduct.Name = newProduct.Name;
                    oldProduct.Price = newProduct.Price;
                    oldProduct.Quantity = newProduct.Quantity;
                    oldProduct.UPC = newProduct.UPC;
                    await _content.SaveChangesAsync();
                    return Ok(oldProduct);
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete]
        public async Task<IHttpActionResult> UpdateProdcutId([FromUri] int Id)
        {
            Product product = await _content.Products.FindAsync(Id);
            if (product == null)
                return NotFound();

            _content.Products.Remove(product);
            await _content.SaveChangesAsync();
            return Ok($"{product.Name} was Removed");
        }
    }
}
