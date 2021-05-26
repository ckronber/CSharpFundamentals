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
    public class CustomerController : ApiController
    {
        private readonly ApplicationDbContext _content = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> Post(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _content.Customers.Add(customer);
                await _content.SaveChangesAsync();
                return Ok(); // 200 (ok) status
            }

            return BadRequest(ModelState);//400 Bad Request
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Customer> customers = await _content.Customers.ToListAsync();
            return Ok(customers);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCustomerById([FromUri] int Id)
        {
            Customer customer = await _content.Customers.FindAsync(Id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateProdcutId([FromUri] int Id, [FromBody] Customer newCustomer)
        {
            if (ModelState.IsValid)
            {
                Customer oldCustomer = await _content.Customers.FindAsync(Id);

                if (oldCustomer != null)
                {
                    oldCustomer.FirstName = newCustomer.FirstName;
                    oldCustomer.LastName = newCustomer.LastName;
                    await _content.SaveChangesAsync();
                    return Ok(oldCustomer);
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete]
        public async Task<IHttpActionResult> UpdateProdcutId([FromUri] int Id)
        {
            Customer customer = await _content.Customers.FindAsync(Id);
            if (customer == null)
                return NotFound();

            _content.Customers.Remove(customer);
            await _content.SaveChangesAsync();
            return Ok($"{customer.FirstName} {customer.LastName} was Removed");
        }
    }
}

