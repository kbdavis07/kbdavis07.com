using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Title = "Web Application Developer Resume";
            ViewBag.Keywords = "Asp.Net, MVC, C#, Web Application, Developer,Resume";
            ViewBag.Description = "Asp.Net MVC C# Web Application Developer Resume available for hire.";
            ViewBag.Subject = "Developer Resume";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Hire()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}