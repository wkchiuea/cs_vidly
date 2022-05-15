using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1 },
                new Customer { Name = "Mary Williams", Id = 2 }
            };

            var viewModel = new CustomerFormViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        // Get: Customers/Details/{id}
        public ActionResult Details(int id)
        {
            var customer = new List<Customer>
            {
                new Customer { Name = "John Smith" },
                new Customer { Name = "Mary Williams" }
            }[id-1];

            return View(customer);
        }
    }
}