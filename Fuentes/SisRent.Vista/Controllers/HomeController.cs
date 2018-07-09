namespace SisRent.Vista.Controllers
{
    using System.Web.Mvc;

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