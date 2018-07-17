namespace SisRent.Vista.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rentar()
        {
            var vmmhAdmin = new Areas.Mantencion.Models.ViewModelMapperHelper();
            var model = new RentarViewModel
            {
                ListaComunas = new ViewModelMapperHelper().ListaComunas(),
                ListaServicios = vmmhAdmin.ListaServicios(),
                ListaVehiculos = vmmhAdmin.ListaVehiculos()
            };

            return View(model);
        }

        public JsonResult CrearReserva(string comunaRetiro, string fechaRetiro, string horaRetiro,
            string comunaEntrega, string fechaEntrega, string horaEntrega, int idVehiculo,
            List<int> servicios, string nombres, string apellidos, string email, string direccion,
            string comuna, string telefono)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var reserva = new ViewModelMapperHelper().CrearReserva(comunaRetiro, fechaRetiro,
                horaRetiro, comunaEntrega, fechaEntrega, horaEntrega, idVehiculo, servicios,
                nombres, apellidos, email, direccion, comuna, telefono);
            if (!reserva.EsValido)
            {
                response = new
                {
                    valid = false,
                    message = reserva.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Informacion()
        {
            ViewBag.Message = "Información";

            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult EnviarCorreo(string titulo, string nombre, string correo,
            string mensaje)
        {
            ViewBag.Correo = "Mensaje Enviado: " + titulo;

            return RedirectToAction("Contacto");
        }
    }
}