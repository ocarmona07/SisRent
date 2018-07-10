namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Web.Mvc;
    
    public class ReservasController : Controller
    {
        // GET: Mantencion/Reservas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mantencion/Reservas/CrearReserva
        public ActionResult CrearReserva()
        {
            return View();
        }
    }
}