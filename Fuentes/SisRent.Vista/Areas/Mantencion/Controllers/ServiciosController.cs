namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Web.Mvc;
    
    public class ServiciosController : Controller
    {
        // GET: Mantencion/Servicios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mantencion/Servicios/AgregarServicio
        public ActionResult AgregarServicio()
        {
            return View();
        }
    }
}