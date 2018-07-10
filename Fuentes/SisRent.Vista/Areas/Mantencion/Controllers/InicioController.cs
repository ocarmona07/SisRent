namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Web.Mvc;
    using Entidades.Request;
    using Models;
    using Negocio.Admin;
    using Negocio.Common;

    public class InicioController : Controller
    {
        private readonly string _urlBase = ConfigurationManager.AppSettings.Get("UrlBase");

        // GET: Mantencion/Inicio
        public ActionResult Index()
        {
            var notif = new Dictionary<string, string>();
            //notif.Add("users|aqua", "Texto de prueba");
            //notif.Add("warning|yellow", "Notificación de prueba");
            var usuario = new UsuariosBo().ObtenerUsuarioPorRut(new UsuariosRequest
            {
                RutUsuario = "159888207"
            }).Usuario;

            var header = new HeaderViewModel
            {
                NombreUsuario = usuario.Nombres + " " + usuario.ApPaterno,
                NombreCompletoUsuario = usuario.Nombres + " " + usuario.ApPaterno +
                                        " " + usuario.ApMaterno,
                ImagenUsuario = _urlBase + usuario.RutaImagen,
                Rol = usuario.Roles.Rol,
                Notificaciones = notif
            };

            var sidebar = new SidebarViewModel
            {
                ListaAccesos = new ListasBo().ObtenerAccesos().Accesos
            };
            Session["SidebarViewModel"] = sidebar;

            var model = new InicioViewModel
            {
                Header = header,
                Sidebar = sidebar
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