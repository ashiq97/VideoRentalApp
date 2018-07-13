using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vanilla_Vivo.Models;

namespace Vanilla_Vivo.Controllers
{
    public class CustomersController : Controller
    {
        //
        // GET: /Customers/
        public ActionResult Index()
        {
            var customer = GetCustomer();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer{ Id = 1 , Name = "John smith"},
                new Customer{ Id = 2 , Name = "Marry WIlliams"}
                
            };
        }

        public ActionResult Details(int? id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            
            return View(customer);
        }



	}
}