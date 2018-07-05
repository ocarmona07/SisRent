using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisRent.Vista.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rent()
        {
            ViewBag.Message = "Rentar Auto";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Información";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto.";

            return View();
        }
    }
}