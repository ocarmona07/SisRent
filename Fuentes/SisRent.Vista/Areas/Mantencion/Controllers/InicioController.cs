namespace SisRent.Vista.Areas.Mantencion.Controllers
{
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
            var usuario = (UsuarioModel)Session["DataUsuario"];
            var claveDefecto =
                CommonBo.Base64Encode(ConfigurationManager.AppSettings.Get("ClaveDefecto"));
            var header = new HeaderViewModel
            {
                NombreUsuario = usuario.Nombres + " " + usuario.ApPaterno,
                NombreCompletoUsuario = usuario.Nombres + " " + usuario.ApPaterno +
                                        " " + usuario.ApMaterno,
                ImagenUsuario = _urlBase + usuario.RutaImagen,
                Rol = usuario.Rol
            };

            #region Notificaciones

            //var notif = new System.Collections.Generic.Dictionary<string, string>
            //{
            //    {"users|aqua", "Texto de prueba"},
            //    {"warning|yellow", "Notificación de prueba"}
            //};
            //header.Notificaciones = notif;

            #endregion

            var sidebar = new SidebarViewModel
            {
                ListaAccesos = new ListasBo().ObtenerAccesos().Accesos
            };

            var estados = new ListasBo().ObtenerEstadisticas();
            var model = new InicioViewModel
            {
                Header = header,
                Sidebar = sidebar,
                Reservas = estados.Reservas,
                Vehiculos = estados.Vehiculos,
                Servicios = estados.Servicios,
                Usuarios = estados.Usuarios,
                CambiarClave = claveDefecto.Equals(usuario.Clave)
            };

            Session["SidebarViewModel"] = sidebar;
            Session["HeaderViewModel"] = header;

            return View(model);
        }

        public ActionResult CerrarSesion()
        {
            Session["DataUsuario"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [HttpPost]
        public JsonResult CambioClave(string claveActual, string claveNueva)
        {
            var response = new
            {
                valid = true,
                message = ""
            };

            var usuario = (UsuarioModel)Session["DataUsuario"];
            if (usuario != null)
            {
                var dataUsuario = new UsuariosBo().ObtenerUsuarioPorRut(new UsuariosRequest
                {
                    RutUsuario = usuario.Rut
                });
                if (dataUsuario.EsValido &&
                    claveActual.Equals(CommonBo.Base64Decode(dataUsuario.Usuario.Clave)))
                {
                    usuario.Clave = CommonBo.Base64Encode(claveNueva);
                    var update = new UsuariosBo().ActualizarUsuario(new UsuariosRequest
                    {
                        Usuario = new ViewModelMapperHelper().CrearUsuario(usuario)
                    });

                    if (!update.EsValido)
                    {
                        response = new
                        {
                            valid = false,
                            message = "Error al cambiar la clave."
                        };
                    }
                }
                else
                {
                    response = new
                    {
                        valid = false,
                        message = "Clave actual incorrecta."
                    };
                }
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = "Error al obtener usuario."
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}