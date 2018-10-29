using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClassCustomer.model;

namespace RestCustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //creater en liste med 3 objekter af typen customer
        private static List<Customer> cList = new List<Customer>()
        {
            new Customer(){Id = 1234, FirstName = "Jens", LastName = "Jensen", YearOfreg = 1988},
            new Customer(){Id = 7895, FirstName = "Tyga", LastName = "Tasten", YearOfreg = 1999},
            new Customer(){Id = 5555, FirstName = "Stuart",LastName = "Stardust", YearOfreg = 2000}
        };

        // GET: api/Customers
        [HttpGet]
        //[Route("api/Customers")]

        //returnere listen med de givne objekter
        public IEnumerable<Customer> GetAll()
        {
            return cList;
        }

        //GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            foreach (var c in cList)
            {
                if (c.Id == id)
                {
                    return c ;
                }
            }

            return null;
        }

        // POST: api/Customers
        // poster et nyt objekt at typen Customer
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            cList.Add(customer);
        }

        // PUT: api/Customers/5
        //opdatere min liste med et nyt obejekt og sletter det gamle objekt.
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            foreach (Customer cl in cList)
            {
                if (id == cl.Id)
                {
                    cList.Remove(cl);
                    cList.Add(customer);
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Customer cd in cList)
            {
                if (id==cd.Id)
                {
                    cList.Remove(cd);
                    return;
                    
                }
            }
        }

        public void Start()
        {
            
        }
    }
}
