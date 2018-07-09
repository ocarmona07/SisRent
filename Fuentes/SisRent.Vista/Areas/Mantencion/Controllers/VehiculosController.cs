namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Web.Mvc;
    using Negocio.Admin;

    public class VehiculosController : Controller
    {
        // GET: Mantencion/Vehiculos
        public ActionResult Index()
        {
            var vehiculo = new VehiculosBo().ObtenerVehiculos();
            ViewBag.MensajeError = vehiculo.MensajeError;

            return View();
        }
    }
}