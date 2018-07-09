namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Web.Mvc;
    using Models;

    public class InicioController : Controller
    {
        private readonly string _urlBase = ConfigurationManager.AppSettings.Get("UrlBase");

        // GET: Mantencion/Inicio
        public ActionResult Index()
        {
            var notif = new Dictionary<string, string>();
            //notif.Add("users|aqua", "Texto de prueba");
            //notif.Add("warning|yellow", "Notificación de prueba");

            var header = new HeaderViewModel
            {
                NombreUsuario = "Omar Carmona",
                NombreCompletoUsuario = "Omar Carmona Rivas",
                ImagenUsuario = _urlBase + "/Images/user2-160x160.jpg",
                Rol = "Administrador",
                Notificaciones = notif
            };
            var model = new InicioViewModel
            {
                Header = header
            };
            Session["HeaderViewModel"] = header;

            return View(model);
        }

        public ActionResult CerrarSesion()
        {
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}