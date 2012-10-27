using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MigrationsTestLayered.Domain;

namespace MigrationsTestLayered.Controllers
{
    public class HomeController : Controller
    {
        IBlogRepository _repository;

        public HomeController(IBlogRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Testing migrations in MVC4 layered app";

            var results = _repository.GetAll();

            return View(results);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
