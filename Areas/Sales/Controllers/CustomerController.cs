using Microsoft.AspNetCore.Mvc;

namespace PC2_Views.Areas.Sales.Controllers
{
    [Area("Sales")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customerList = new List<Customer>()
            {
                new Customer() { CustomerID = 1, FullName = "Jose",Email="jose@email.com",Country="Peru",Phone="9090909120"} ,
                new Customer() { CustomerID = 2, FullName = "Carlos",Email="Carlos@email.com",Country="Chile",Phone="9998981238" } ,
                new Customer() { CustomerID = 3, FullName = "Bryan",Email="Bryan@email.com",Country="Peru",Phone="97867889" } ,
                new Customer() { CustomerID = 4, FullName = "Daniel" ,Email="Daniel@email.com",Country="Peru",Phone="90898675672"} ,
                new Customer() { CustomerID = 5, FullName = "Eduardo" ,Email="Eduardo@email.com",Country="Colombia",Phone="9288788633"}
            };

           return View("Index", customerList);
        }

        public class Customer
        {
            public int CustomerID { get; set; }
            public string FullName { get; set; }

            public string Email { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
        }

    }
}
