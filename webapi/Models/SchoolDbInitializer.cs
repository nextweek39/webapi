using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using webapi.Models;
using webapi.Entities;
namespace webapi.Models
{
    public class SchoolDbInitializer : DropCreateDatabaseIfModelChanges<SchoolDbContext>
    {
        protected override void Seed(SchoolDbContext context)
        {
            List<Customer> custList = new List<Customer>();

            custList.Add(new Customer() { CustFname = "Mark Aris", CustLname = "Trinidad" , Address = "Cebu City"});
            custList.Add(new Customer() { CustFname = "Michael Aris", CustLname = "Trinidad", Address = "Manila City" });
            custList.Add(new Customer() { CustFname = "Anna Mae", CustLname = "Trinidad", Address = "London" });
            custList.Add(new Customer() { CustFname = "Ailee Mae", CustLname = "Trinidad", Address = "Ghent" });


            foreach (Customer cust in custList)
            {
                context.Customer.Add(cust);                
            }

            context.SaveChanges();

            base.Seed(context);

        }

    }
}