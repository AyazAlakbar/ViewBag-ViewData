using Microsoft.AspNetCore.Mvc;
using SQL_Connection.DAL_data_access_layer_;
using SQL_Connection.Models;
using System.Collections.Generic;
using System.Linq;

namespace SQL_Connection.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            //List<Student> Students = _appDbContext.Students.ToList();
            //Student student = _appDbContext.Students.Find(1);
            Student student = _appDbContext.Students.FirstOrDefault(s=>s.Id==2);
            return View();
        }


        public IActionResult About()
        {
            return View();
        }
    }
}
