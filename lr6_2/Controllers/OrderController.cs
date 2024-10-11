using lr6_2.Models;
using Microsoft.AspNetCore.Mvc;
using lr6_2.Models;

namespace lr6_2.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Age > 16)
                {
                    return RedirectToAction("OrderProducts", new { productCount = user.ProductCount });
                }
                else
                {
                    return View("UnderAge");
                }
            }
            return View(user);
        }

        public IActionResult OrderProducts(int productCount)
        {
            ViewBag.ProductCount = productCount;
            return View();
        }

        [HttpPost]
        public IActionResult OrderProducts(Product[] products)
        {
            return View("OrderSummary", products);
        }
    }
}
