namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class UsuariosController : Controller
    {
        // GET: Mantencion/Usuarios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mantencion/Usuarios/AgregarUsuario
        public ActionResult AgregarUsuario()
        {
            return View();
        }
    }
}