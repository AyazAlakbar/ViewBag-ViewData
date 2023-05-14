using Microsoft.AspNetCore.Mvc;
using ViewBagViewData.Models;

namespace ViewBagViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //ViewData
            var p = new Product
            {
                Id = 1,
                Name = "Product1",
                Price = 55
            };
            //ViewData["ProductName"]= p.Name;


            //ViewData["Id"] = "Id";
            //ViewData["Name"] = "Name";
            //ViewData["Price"] = "Price";

            //ViewBag

            ViewBag.Id = 2;
            ViewBag.Name = "Name";
            ViewBag.Price = 25;

            return View();
        }
    }
}
