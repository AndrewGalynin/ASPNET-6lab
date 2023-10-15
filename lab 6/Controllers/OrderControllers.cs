using Microsoft.AspNetCore.Mvc;
using PizzaOrder.Models;
using System.Collections.Generic;

namespace PizzaOrder.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (user.Age > 16)
            {
                return View("ProductForm", user);
            }
            else
            {
                return View("OrderSummary", new List<Product>());
            }
        }

        [HttpPost]
        public IActionResult ProductForm(List<Product> products)
        {
            return View("OrderSummary", products);
        }
    }
}


