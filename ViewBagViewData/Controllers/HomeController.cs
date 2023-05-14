using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

            var p1 = new Product
            {
                Id = 2,
                Name = "Product2",
                Price = 55
            };
            ViewData["ProductName"] = p.Name;


            ViewData["Id"] = "Id";
            ViewData["Name"] = "Name";
            ViewData["Price"] = "Price";

            //ViewBag

            ViewBag.Id = 2;
            ViewBag.Name = "Name";
            ViewBag.Price = 25;


            var productList = new List<Product>();
            productList.Add(p);
            productList.Add(p1);
            ViewBag.Products = productList;

            TempData["Id"] = 2;
            TempData["Name"] = "Name";
            TempData["Price"] = 99;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
