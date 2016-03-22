using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using webapi.Entities;
using webapi.Models;
namespace webapi.Controllers
{
    [AllowAnonymous]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Customer> Get()
        {
            //return new string[] { "value1", "value2" };
            List<Customer> custlist = new List<Customer>();
            Customer cust = new Customer();
            using (var ctx = new SchoolDbContext())
            {
                foreach(var customer in ctx.Customer)
                {
                    cust.CustFname = customer.CustFname;
                    cust.CustLname = customer.CustLname;
                    cust.Address = customer.Address;
                    custlist.Add(cust);
                }

                IEnumerable<Customer> customers = custlist;
                return customers;
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
