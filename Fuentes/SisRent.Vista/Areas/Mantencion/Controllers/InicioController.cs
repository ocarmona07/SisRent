namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Configuration;
    using System.Web.Mvc;
    using Models;
    using Negocio.Common;

    public class InicioController : Controller
    {
        private readonly string _urlBase = ConfigurationManager.AppSettings.Get("UrlBase");

        // GET: Mantencion/Inicio
        public ActionResult Index()
        {
            //var notif = new Dictionary<string, string>();
            //notif.Add("users|aqua", "Texto de prueba");
            //notif.Add("warning|yellow", "Notificación de prueba");
            var usuario = (UsuarioModel) Session["DataUsuario"];
            var header = new HeaderViewModel
            {
                NombreUsuario = usuario.Nombres + " " + usuario.ApPaterno,
                NombreCompletoUsuario = usuario.Nombres + " " + usuario.ApPaterno +
                                        " " + usuario.ApMaterno,
                ImagenUsuario = _urlBase + usuario.RutaImagen,
                Rol = usuario.Rol,
                Notificaciones = null//notif
            };

            var sidebar = new SidebarViewModel
            {
                ListaAccesos = new ListasBo().ObtenerAccesos().Accesos
            };
            Session["SidebarViewModel"] = sidebar;

            var estados = new ListasBo().ObtenerEstadisticas();
            var model = new InicioViewModel
            {
                Header = header,
                Sidebar = sidebar,
                Reservas = estados.Reservas,
                Vehiculos = estados.Vehiculos,
                Servicios = estados.Servicios,
                Usuarios = estados.Usuarios
            };
            Session["HeaderViewModel"] = header;

            return View(model);
        }

        public ActionResult CerrarSesion()
        {
            Session["DataUsuario"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}